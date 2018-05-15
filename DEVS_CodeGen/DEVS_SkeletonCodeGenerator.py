from CodeGen import *
from Model import *
from DEVS_XMLParser import *


def AM_Header_Gen():
    return NULL

def AM_CPP_Gen():
    return NULL

# Coupled Model
# Header
def CM_Header_Gen():
    cpp = CppFile("Coupled_test.h")
    cpp("#include \"DEVSim.h\"")
    cpp("#include <string>\n")

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

# Coupled Model
# CppFile
def CM_CPP_Gen():
    return NULL

#ReadXML("DEVS_Structure.xml")

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
