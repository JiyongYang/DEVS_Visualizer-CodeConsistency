#include "A_SubModuleB.h"

std::string A_SubModuleB::Input_AA1 = "Input_AA1";
std::string A_SubModuleB::Input_AB1 = "Input_AB1";
std::string A_SubModuleB::Output_B11111111111111 = "Output_B11111111111111";

A_SubModuleB::A_SubModuleB()
{
	// Constructor
	SetName("A_SubModuleB");

	// Input ports
	AddInPorts(1, Input_AA1.c_str());
	AddInPorts(1, Input_AB1.c_str());
	// Output Ports
	AddOutPorts(1, Output_B11111111111111.c_str());
	
	// Models
	CModel* b_submoduleb = new B_SubModuleB();
	AddComponent(1, b_submoduleb);
	
	// Coupling
	AddCoupling(this, A_SubModuleB::Input_AA1.c_str(), b_submoduleb, B_SubModuleB::Input_C1.c_str());
	AddCoupling(this, A_SubModuleB::Input_AB1.c_str(), b_submoduleb, B_SubModuleB::Input_C1.c_str());
	AddCoupling(b_submoduleb, B_SubModuleB::Output_C1.c_str(), this, A_SubModuleB::Output_B11111111111111.c_str());
}

A_SubModuleB::~A_SubModuleB()
{
	// Destructor
}
