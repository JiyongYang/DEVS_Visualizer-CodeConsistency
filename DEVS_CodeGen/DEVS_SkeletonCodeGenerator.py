from CodeGen import *
from Model import *
from DEVS_XMLParser import *

_this = "this"

def AM_Header_Gen(modelObj):
    amName = modelObj.cName
    amPorts = modelObj.cPorts
    cpp = CppFile(amName + ".h")
    # [Fix] start
    cpp("#include \"DEVSim.h\"")
    cpp("#include <string>\n")
    # [Fix] End
    lstPorts = []
    for i in amPorts:
        lstPorts += [i.cName]
    VAR_NAMES = {amName: lstPorts}

    with cpp.subs(ClassName=amName):
        with cpp.block("class $ClassName$ : public CAtomic", ";"):
            cpp.label("public")
            cpp("$ClassName$();")
            cpp("~$ClassName$();\n")
            cpp.label("public")
            cpp("virtual bool ExtTransFn(const CDEVSimMessage &);")
            cpp("virtual bool IntTransFn();")
            cpp("virtual bool OutputFn(CDEVSimMessage &);")
            cpp("virtual TimeType TimeAdvanceFn();\n")
            cpp.label("public")
            for varName in VAR_NAMES[amName]:
                with cpp.subs(_Var=varName, _var=varName.lower()):
                    cpp("static std::string $_Var$;")

    cpp.close()


def AM_CPP_Gen(modelObj):
    amName = modelObj.cName
    amPorts = modelObj.cPorts
    cpp = CppFile(amName + ".cpp")
    # [Fix] start
    cpp("#include \"" + amName + ".h\"\n")
    # [Fix] End

    lstPorts = []
    for i in amPorts:
        lstPorts += [i.cName]
    VAR_NAMES = {amName: lstPorts}

    # initialize Port name
    for varName in VAR_NAMES[amName]:
        with cpp.subs(_Var=varName, _var=varName.lower()):
            cpp("std::string " + amName + "::$_Var$ = \"$_Var$\";")
    cpp("")

    with cpp.block(amName+"::"+amName+"()"):
        cpp("// Constructor")
        cpp("SetName(\""+amName+"\");\n")

        # AddPorts
        cpp("// Input ports")
        for pt in amPorts:
            if(pt.cType == Type.IN):
                cpp("AddInPorts(1, "+pt.cName+".c_str());")
        cpp("// Output Ports")
        for pt in amPorts:
            if (pt.cType == Type.OUT):
                cpp("AddOutPorts(1, " + pt.cName + ".c_str());")
    cpp("")

    with cpp.block(amName + "::~" + amName + "()"):
        cpp("// Destructor")

    cpp("\nbool " + amName + "::ExtTransFn(const CDEVSimMessage & msg)\n{\n	return ;\n}\n")
    cpp("bool " + amName + "::IntTransFn()\n{\n	return ;\n}\n")
    cpp("bool " + amName + "::OutputFn(CDEVSimMessage & msg)\n{\n	return ;\n}\n")
    cpp("bool " + amName + "::TimeAdvanceFn()\n{\n	return ;\n}\n")
    cpp.close()

# Coupled Model
# Header
def CM_Header_Gen(modelObj):
    cmName = modelObj.cName
    cmPorts = modelObj.cPorts
    cpp = CppFile(cmName+".h")

    # [Fix] start
    cpp("#include \"DEVSim.h\"")
    cpp("#include <string>\n")
    # [Fix] End

    lstPorts = []
    for i in cmPorts:
        lstPorts += [i.cName]

    VAR_NAMES = { cmName: lstPorts }
    with cpp.subs(ClassName=cmName):
        with cpp.block("class $ClassName$ : public CCoupled", ";"):
            cpp.label("public")
            cpp("$ClassName$();")
            cpp("~$ClassName$();\n")
            cpp.label("public")
            for varName in VAR_NAMES[cmName]:
                with cpp.subs(_Var=varName, _var=varName.lower()):
                    cpp("static std::string $_Var$;")
    cpp.close()

# Coupled Model
# CppFile
def CM_CPP_Gen(modelObj):
    cmName = modelObj.cName
    cmPorts = copy.deepcopy(modelObj.cPorts)
    cmSubModel = copy.deepcopy(modelObj.cInstances)
    cmCoupling = []
    _cmCoupling = copy.deepcopy(modelObj.cCouplings)

    fullNamelst = modelObj.cFullname.split(".")
    parentModelName = ("Outmost_except" if len(fullNamelst) == 1 else fullNamelst[-2])
    print(modelObj.cFullname +" || "+parentModelName)

    #get coupling information
    for subM in modelObj.cInstances:
        _cmCoupling += copy.deepcopy(subM.cCouplings)

    for cp in _cmCoupling:
        if((cp.cFrom == cmName or cp.cTo == cmName) and cp.cFrom != parentModelName and cp.cTo != parentModelName):
            cmCoupling += [cp]

    cpp = CppFile(cmName + ".cpp")

    # [Fix] start
    cpp("#include \""+cmName+".h\"\n")
    # [Fix] End

    lstPorts = []
    for i in cmPorts:
        lstPorts += [i.cName]
    VAR_NAMES = {cmName: lstPorts}

    # initialize Port name
    for varName in VAR_NAMES[cmName]:
        with cpp.subs(_Var=varName, _var=varName.lower()):
            cpp("std::string "+cmName+"::$_Var$ = \"$_Var$\";")
    cpp("")

    with cpp.block(cmName+"::"+cmName+"()"):
        cpp("// Constructor")
        cpp("SetName(\""+cmName+"\");\n")

        # AddPorts
        cpp("// Input ports")
        for pt in cmPorts:
            if(pt.cType == Type.IN):
                cpp("AddInPorts(1, "+pt.cName+".c_str());")
        cpp("// Output Ports")
        for pt in cmPorts:
            if (pt.cType == Type.OUT):
                cpp("AddOutPorts(1, " + pt.cName + ".c_str());")
        cpp("")

        # SubModel
        cpp("// Models")
        for sm in cmSubModel:
            cpp("CModel* "+sm.cName.lower()+" = new "+sm.cName+"();")
            cpp("AddComponent(1, "+sm.cName.lower()+");")
        cpp("")

        # Coupling
        cpp("// Coupling")
        for cp in cmCoupling:
            cpp("AddCoupling("+ (_this if cp.cFrom == cmName else cp.cFrom.lower()) + \
                ", " + cp.cFrom+"::"+cp.cFPort+".c_str(), "+ (_this if cp.cTo == cmName else cp.cTo.lower()) + \
                ", " + cp.cTo+"::"+cp.cTPort+".c_str());" \
                )
    cpp("")
    with cpp.block(cmName + "::~" + cmName + "()"):
        cpp("// Destructor")

    cpp.close()

def SkeletonCodeGen():
    CM_Header_Gen(OutmostModel)
    CM_CPP_Gen(OutmostModel)

    SkeletonCodeGen_recur(OutmostModel.cInstances)


def SkeletonCodeGen_recur(_submodels):
    for _model in _submodels:
        if (_model.cModelType == "Coupled"):
            CM_Header_Gen(_model)
            CM_CPP_Gen(_model)
        else:
            AM_Header_Gen(_model)
            AM_CPP_Gen(_model)
        if(len(_model.cInstances) > 0):
            SkeletonCodeGen_recur(_model.cInstances)


ReadXML("DEVS_Structure.xml")

SkeletonCodeGen()

print("done")


