#include "A_SubModuleA.h"

// [Region] Ports_init
std::string A_SubModuleA::Input_AA1 = "Input_AA1";
std::string A_SubModuleA::Input_AB1 = "Input_AB1";
std::string A_SubModuleA::Output_B11111111111111 = "Output_B11111111111111";
// [EndRegion] Ports_init

A_SubModuleA::A_SubModuleA()
{
	// Constructor
	SetName("A_SubModuleA");

	// [Region] Ports_reg
	// Input ports
	AddInPorts(1, Input_AA1.c_str());
	AddInPorts(1, Input_AB1.c_str());
	// Output Ports
	AddOutPorts(1, Output_B11111111111111.c_str());
	// [EndRegion] Ports_reg

	// [Region] Models
	CModel* b_submoduleb = new B_SubModuleB();
	AddComponent(1, b_submoduleb);
	// [EndRegion] Models

	// [Region] Couplings
	AddCoupling(this, A_SubModuleA::Input_AA1.c_str(), b_submoduleb, B_SubModuleB::Input_C1.c_str());
	AddCoupling(this, A_SubModuleA::Input_AB1.c_str(), b_submoduleb, B_SubModuleB::Input_C1.c_str());
	AddCoupling(b_submoduleb, B_SubModuleB::Output_C1.c_str(), this, A_SubModuleA::Output_B11111111111111.c_str());
	// [EndRegion] Couplings
}

A_SubModuleA::~A_SubModuleA()
{
	// Destructor
}
