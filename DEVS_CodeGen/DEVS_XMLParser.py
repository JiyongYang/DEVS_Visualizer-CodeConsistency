import xml.etree.ElementTree as ET
from Model import *

OutmostModel = Model("NULL", "NULL", "None")
ModelPool = dict()
BaseModels = dict()

def ReadXML(fileName):
    doc = ET.parse(fileName)
    root = doc.getroot()

    for child in root:
        if(child.tag == "OutmostModel"):
            OutmostModel.cName = child.attrib["name"]
            OutmostModel.cFullname = child.attrib["name"]
            ParsingXML_r(child, OutmostModel, child.attrib["name"], 1)
        elif(child.tag == "ModelPool"):
            ParsingXML_p(child, 1)
        else:
            print("[----Error----]")

def ParsingXML_r(elements, mod, fullname, depth):
    for child in elements:
        if(child.tag == "Port"):
            pt = Port(Type.IN if child.attrib["type"] == "In" else Type.OUT, child.text)
            mod.cPorts += [pt]
        elif(child.tag == "SubModel"):
            tModel = Model(child.attrib["name"], fullname+"."+child.attrib["name"], "None")
            ParsingXML_r_readSubModel(child, [tModel], fullname + "." + child.attrib["name"], depth + 1)
            mod.cInstances += [tModel]
        else:
            print("[----Error----]" + child.tag)

def ParsingXML_r_readSubModel(elements, mod, fullname, depth):
    mod = mod[0]
    for child in elements:
        if(child.tag == "Type"):
            mod.cType = child.text
        elif(child.tag == "Coupling"):
            cp = Coupling(child.attrib["from"], child.attrib["fPort"], child.attrib["to"], child.attrib["tPort"])
            mod.cCouplings += [cp]
        elif(child.tag == "SubModel"):
            tModel = Model(child.attrib["name"], fullname+"."+child.attrib["name"], "None")
            ParsingXML_r_readSubModel(child, [tModel], fullname+"."+child.attrib["name"], depth+1)
            mod.cInstances += [tModel]
        else:
            print("[----Error----]" + child.tag)

def ParsingXML_p(elements, depth):
    for child in elements:
        if(child.tag == "Port"):
            pt = Port(Type.IN if child.attrib["type"] == "In" else Type.OUT, child.text)
            print(pt)
        elif(child.tag == "SubModel"):
            print(child.tag)
        else:
            print("[----Error----]  " + child.tag)


ReadXML("DEVS_Structure.xml")
