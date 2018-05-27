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

    CLASS_NAMES = [amPorts]
    VAR_NAMES = {amPorts: lstPorts}
    for className in CLASS_NAMES:
        with cpp.subs(ClassName=className):
            with cpp.block("class $ClassName$ : public CAtomic", ";"):
                cpp.label("public")
                for varName in VAR_NAMES[className]:
                    with cpp.subs(_Var=varName, _var=varName.lower()):
                        cpp("static std::string $_Var$;")
                cpp.label("public")
                cpp.block("$ClassName$()")
                cpp.block("~$ClassName$()")
    cpp.close()


def AM_CPP_Gen():
    return "None"

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

    CLASS_NAMES = [cmName]
    VAR_NAMES = { cmName: lstPorts }
    for className in CLASS_NAMES:
        with cpp.subs(ClassName=className):
            with cpp.block("class $ClassName$ : public CCoupled", ";"):
                cpp.label("public")
                for varName in VAR_NAMES[className]:
                    with cpp.subs(_Var=varName, _var=varName.lower()):
                        cpp("static std::string $_Var$;")
                cpp.label("public")
                cpp.block("$ClassName$()")
                cpp.block("~$ClassName$()")
    cpp.close()

""" [][][] backup
def CM_Header_Gen(cmName, ):
    cpp = CppFile("Coupled_test.h")

    # [Fix] start
    cpp("#include \"DEVSim.h\"")
    cpp("#include <string>\n")
    # [Fix] End


    CLASS_NAMES = ["Coupled_test"]
    VAR_NAMES = { "Coupled_test": ["inport_1", "inport_2", "outport_1"] }
    for className in CLASS_NAMES:
        with cpp.subs(ClassName=className):
            with cpp.block("class $ClassName$ : public CCoupled", ";"):
                cpp.label("public")
                for varName in VAR_NAMES[className]:
                    with cpp.subs(_Var=varName, _var=varName.lower()):
                        cpp("static std::string $_Var$;")
                cpp.label("public")
                cpp.block("$ClassName$()")
                cpp.block("~$ClassName$()")
    cpp.close()
"""

# Coupled Model
# CppFile
def CM_CPP_Gen(cmName, cmPorts, cmSubModel, cmCoupling):
    cpp = CppFile(cmName + ".cpp")

    # [Fix] start
    cpp("#include \""+cmName+".h\"")
    cpp("")
    # [Fix] End

    lstPorts = []
    for i in cmPorts:
        lstPorts += [i.cName]

    CLASS_NAMES = [cmName]
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
    with cpp.block("~"+cmName + "::" + cmName + "()"):
        cpp("// Destructor")
    """
    for className in CLASS_NAMES:
        with cpp.subs(ClassName=className):
            with cpp.block("class $ClassName$ : public CCoupled", ";"):
                cpp.label("public")
                for varName in VAR_NAMES[className]:
                    with cpp.subs(_Var=varName, _var=varName.lower()):
                        cpp("static std::string $_Var$;")
                cpp.label("public")
                cpp.block("$ClassName$()")
                cpp.block("~$ClassName$()")
    """
    cpp.close()


ReadXML("DEVS_Structure.xml")



CM_Header_Gen(OutmostModel.cName, copy.deepcopy(OutmostModel.cPorts))
CM_CPP_Gen(OutmostModel.cName, copy.deepcopy(OutmostModel.cPorts), copy.deepcopy(OutmostModel.cInstances), copy.deepcopy(OutmostModel.cCouplings))








"""
cpp = CppFile("Coupled_test.cpp")

cpp("#include \"Coupled_test.h\"\n")

CLASS_NAMES = ["Coupled_test"]
VAR_NAMES = { "Coupled_test": ["inport_1", "inport_2", "outport_1"] }

for value in VAR_NAMES["Coupled_test"]:
    with cpp.subs(val=value):
        cpp("std::string Coupled_test::$val$ = \"$val$\"")
cpp("")

for className in CLASS_NAMES:
    with cpp.subs(ClassName=className):
        with cpp.block("$ClassName$::$ClassName$", ";"):
            cpp("SetName(\"[Model Name]\");")
            # IN Ports
            cpp("// IN Ports")
            cpp("AddInPorts(1, [Port Name].c_str());")
            # OUT Ports
            cpp("// OUT Ports")
            cpp("AddOutPorts(1, [Port Name].c_str());")
        with cpp.block("~$ClassName$::$ClassName$", ";"):
            cpp("//Destructor")

cpp.close()






# Atomic Model

cpp = CppFile("Atomic_test.h")
CLASS_NAMES = ["Atomic_test"]
VAR_NAMES = { "Atomic_test": ["inport_1", "inport_2", "outport_1"] }

for className in CLASS_NAMES:
    with cpp.subs(ClassName=className):
        with cpp.block("class $ClassName$ : public CCoupled", ";"):
            cpp.label("public")
            for varName in VAR_NAMES[className]:
                with cpp.subs(_Var=varName, _var=varName.lower()):
                    cpp("static std::string $_Var$;")
            cpp.label("public")
            with cpp.subs(**{"A a": ", ".join([x + " " + x.lower() for x in VAR_NAMES[className]])}):
                with cpp.block("$ClassName$()"):
                    for varName in VAR_NAMES[className]:
                        with cpp.subs(a=varName.lower()):
                            cpp("this->$a$ = $a$;")
            for varName in VAR_NAMES[className]:
                with cpp.subs(A=varName, a=varName.lower(), getA="get"+varName):
                    with cpp.block("$A$ $getA$()"):
                        cpp("return this->$a$;")

cpp.close()
"""