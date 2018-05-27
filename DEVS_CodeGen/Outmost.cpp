#include "Outmost.h"

std::string Outmost::OutMost_Input_1 = "OutMost_Input_1";
std::string Outmost::OutMost_Input_2 = "OutMost_Input_2";
std::string Outmost::OutMost_Output_1 = "OutMost_Output_1";

Outmost::Outmost()
{
	// Constructor
	SetName("Outmost");

	// Input ports
	AddInPorts(1, OutMost_Input_1.c_str());
	AddInPorts(1, OutMost_Input_2.c_str());
	// Output Ports
	AddOutPorts(1, OutMost_Output_1.c_str());
	
	// Models
	CModel* a_submodulea = new A_SubModuleA();
	AddComponent(1, a_submodulea);
	CModel* a_submoduleb = new A_SubModuleB();
	AddComponent(1, a_submoduleb);
	
	// Coupling
}

Outmost::~Outmost()
{
	// Destructor
}
