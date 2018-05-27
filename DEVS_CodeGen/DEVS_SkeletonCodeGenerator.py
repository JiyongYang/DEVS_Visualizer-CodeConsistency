from CodeGen import *
from Model import *
from DEVS_XMLParser import *

_this = "this"

def AM_Header_Gen(amName, amPorts):
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


def AM_CPP_Gen(amName, amPorts):
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
def CM_Header_Gen(cmName, cmPorts):
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
def CM_CPP_Gen(cmName, cmPorts, cmSubModel, cmCoupling):
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
            cpp("AddCoupling("+ _this if cp.cFrom == cmName else cp.cFrom.lower() + \
                ", " + cp.cFrom+"::"+cp.cFPort+".c_str(), "+ _this if cp.cTo == cmName else cp.cTo.lower() + \
                ", " + cp.cTo+"::"+cp.cTPort+".c_str();"
                )
    cpp("")
    with cpp.block(cmName + "::~" + cmName + "()"):
        cpp("// Destructor")

    cpp.close()


ReadXML("DEVS_Structure.xml")


# test gen Coupled
CM_Header_Gen(OutmostModel.cName, copy.deepcopy(OutmostModel.cPorts))
CM_CPP_Gen(OutmostModel.cName, copy.deepcopy(OutmostModel.cPorts), copy.deepcopy(OutmostModel.cInstances), copy.deepcopy(OutmostModel.cCouplings))

# test gen Atomic
AM_Header_Gen(ModelPool["ModelC"].cName, copy.deepcopy(ModelPool["ModelC"].cPorts))
AM_CPP_Gen(ModelPool["ModelC"].cName, copy.deepcopy(ModelPool["ModelC"].cPorts))

print("done")


