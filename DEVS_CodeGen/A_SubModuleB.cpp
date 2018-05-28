#include "A_SubModuleB.h"

// [Region] Ports_init
std::string A_SubModuleB::Input_AA1 = "Input_AA1";
std::string A_SubModuleB::Input_AB1 = "Input_AB1";
std::string A_SubModuleB::Output_B11111111111111 = "Output_B11111111111111";
// [EndRegion] Ports_init

A_SubModuleB::A_SubModuleB()
{
	// Constructor
	SetName("A_SubModuleB");

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
	AddCoupling(this, A_SubModuleB::Input_AA1.c_str(), b_submoduleb, B_SubModuleB::Input_C1.c_str());
	AddCoupling(this, A_SubModuleB::Input_AB1.c_str(), b_submoduleb, B_SubModuleB::Input_C1.c_str());
	AddCoupling(b_submoduleb, B_SubModuleB::Output_C1.c_str(), this, A_SubModuleB::Output_B11111111111111.c_str());
	// [EndRegion] Couplings
}

A_SubModuleB::~A_SubModuleB()
{
	// Destructor
}
