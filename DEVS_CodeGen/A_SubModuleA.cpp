#include "A_SubModuleA.h"

std::string A_SubModuleA::Input_AA1 = "Input_AA1";
std::string A_SubModuleA::Input_AB1 = "Input_AB1";
std::string A_SubModuleA::Output_B11111111111111 = "Output_B11111111111111";

A_SubModuleA::A_SubModuleA()
{
	// Constructor
	SetName("A_SubModuleA");

	// Input ports
	AddInPorts(1, Input_AA1.c_str());
	AddInPorts(1, Input_AB1.c_str());
	// Output Ports
	AddOutPorts(1, Output_B11111111111111.c_str());
	
	// Models
	CModel* b_submoduleb = new B_SubModuleB();
	AddComponent(1, b_submoduleb);
	
	// Coupling
	AddCoupling(this, A_SubModuleA::Input_AA1.c_str(), b_submoduleb, B_SubModuleB::Input_C1.c_str());
	AddCoupling(this, A_SubModuleA::Input_AB1.c_str(), b_submoduleb, B_SubModuleB::Input_C1.c_str());
	AddCoupling(b_submoduleb, B_SubModuleB::Output_C1.c_str(), this, A_SubModuleA::Output_B11111111111111.c_str());
}

A_SubModuleA::~A_SubModuleA()
{
	// Destructor
}
