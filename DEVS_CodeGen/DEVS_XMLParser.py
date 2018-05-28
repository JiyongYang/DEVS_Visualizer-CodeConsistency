import xml.etree.ElementTree as ET
import copy
from Model import *

OutmostModel = Model("NULL", "NULL", "None", "Coupled")
ModelPool = dict()

# Read XML according to XML file(DEVS_Structure.xml)
def ReadXML(fileName):
    doc = ET.parse(fileName)
    root = doc.getroot()

    for child in root:
        # For real DEVS structure
        if(child.tag == "OutmostModel"):
            OutmostModel.cName = child.attrib["name"]
            OutmostModel.cFullname = child.attrib["name"]
            ParsingXML_r(child, OutmostModel, child.attrib["name"], 1)
        # For Model pool
        elif(child.tag == "ModelPool"):
            ParsingXML_p(child, 1)
        else:
            print("[----Error----]" + child.tag)

    UpdateModelInfo_recur(OutmostModel.cInstances)

# DEVS real structure (for Outmost model)
def ParsingXML_r(elements, mod, fullname, depth):
    for child in elements:
        if(child.tag == "Port"):
            pt = Port(Type.IN if child.attrib["type"] == "In" else Type.OUT, child.text)
            mod.cPorts += [pt]
        elif(child.tag == "SubModel"):
            tModel = Model(child.attrib["name"], fullname+"."+child.attrib["name"], child.attrib["type"], "None")
            ParsingXML_rp_readSubModel(child, [tModel], fullname + "." + child.attrib["name"], depth + 1)
            mod.cInstances += [tModel]
        else:
            print("[----Error----]" + child.tag)

# Recursively call itself to read SubModels
def ParsingXML_rp_readSubModel(elements, mod, fullname, depth):
    mod = mod[0]
    for child in elements:
        if(child.tag == "Type"):
            mod.cType = child.text
        elif(child.tag == "Coupling"):
            cp = Coupling(child.attrib["from"], child.attrib["fPort"], child.attrib["to"], child.attrib["tPort"])
            mod.cCouplings += [cp]
        elif(child.tag == "SubModel"):
            tModel = Model(child.attrib["name"], fullname+"."+child.attrib["name"], child.attrib["type"], "None")
            ParsingXML_rp_readSubModel(child, [tModel], fullname+"."+child.attrib["name"], depth+1)
            mod.cInstances += [tModel]
        else:
            print("[----Error----]" + child.tag)

# Read model pool data
def ParsingXML_p(elements, depth):
    for child in elements:
        if(child.tag == "Model"):
            childName = child.attrib["name"]
            tModel = Model(childName, childName, child.attrib["type"], "None")
            for ele in child.iter("Port"):
                pt = Port(Type.IN if ele.attrib["type"] == "In" else Type.OUT, ele.text)
                tModel.cPorts += [pt]
            for ele in child.iter("SubModel"):
                tSubModel = Model(ele.attrib["name"], childName+"."+ele.attrib["name"], ele.attrib["type"], "None")
                ParsingXML_rp_readSubModel(ele, [tSubModel], childName, depth+1)
                tModel.cInstances += [tSubModel]
            ModelPool[childName] = tModel


# Adding information according to <type, modelPool> pair
def UpdateModelInfo():
    # for oustmost
    for i in OutmostModel.cInstances:
        # find model
        ModelInfo = ModelPool[i.cType]
        i.cPorts += ModelInfo.cPorts
        i.cInstances += ModelInfo.cInstances
        i.cType = i.cType + "/Done"
        if( len(i.cInstances) > 0 ):
            UpdateModelInfo_recur(i.cInstances)

    # for Recursive

def UpdateModelInfo_recur(submodels):
    for i in submodels:
        print(i.cName)
        ModelInfo = copy.deepcopy(ModelPool[i.cType])
        omName = copy.deepcopy(i.cName)
        mpName = copy.deepcopy(ModelInfo.cName)
        # rename coupling from/to
        for cp in ModelInfo.cCouplings:
            if(cp.cFrom == mpName):
                cp.cFrom = omName
            if(cp.cTo == mpName):
                cp.cTo = omName
        for sm in ModelInfo.cInstances:
            for cp in sm.cCouplings:
                if (cp.cFrom == mpName):
                    cp.cFrom = omName
                if (cp.cTo == mpName):
                    cp.cTo = omName

        i.cPorts += ModelInfo.cPorts
        i.cInstances += ModelInfo.cInstances
        i.cCouplings += ModelInfo.cCouplings
        i.cType = i.cType + "/Done"
        if( len(i.cInstances) > 0 ):
            UpdateModelInfo_recur(i.cInstances)

