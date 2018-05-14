from CodeGen import *
import xml.etree.ElementTree as ET

doc = ET.parse("DEVS_Structure.xml")
root = doc.getroot()



cpp = CppFile("test.cpp")

# Coupled Model
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
            for varName in VAR_NAMES[className]:
                with cpp.subs(A=varName, a=varName.lower(), getA="get"+varName):
                    with cpp.block("$A$ $getA$()"):
                        cpp("return this->$a$;")


# Atomic Model

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
