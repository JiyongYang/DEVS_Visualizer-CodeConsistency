#include "Outmost.h"

// [Region] Ports_init
std::string Outmost::OutMost_Input_1 = "OutMost_Input_1";
std::string Outmost::OutMost_Input_2 = "OutMost_Input_2";
std::string Outmost::OutMost_Output_1 = "OutMost_Output_1";
// [EndRegion] Ports_init

Outmost::Outmost()
{
	// Constructor
	SetName("Outmost");

	// [Region] Ports_reg
	// Input ports
	AddInPorts(1, OutMost_Input_1.c_str());
	AddInPorts(1, OutMost_Input_2.c_str());
	// Output Ports
	AddOutPorts(1, OutMost_Output_1.c_str());
	// [EndRegion] Ports_reg

	// [Region] Models
	CModel* a_submodulea = new A_SubModuleA();
	AddComponent(1, a_submodulea);
	CModel* a_submoduleb = new A_SubModuleB();
	AddComponent(1, a_submoduleb);
	// [EndRegion] Models

	// [Region] Couplings
	AddCoupling(this, Outmost::OutMost_Input_1.c_str(), a_submodulea, A_SubModuleA::Input_AA1.c_str());
	AddCoupling(this, Outmost::OutMost_Input_1.c_str(), a_submodulea, A_SubModuleA::Input_AB1.c_str());
	AddCoupling(a_submodulea, A_SubModuleA::Output_B11111111111111.c_str(), this, Outmost::OutMost_Output_1.c_str());
	AddCoupling(this, Outmost::OutMost_Input_2.c_str(), a_submoduleb, A_SubModuleB::Input_AA1.c_str());
	AddCoupling(this, Outmost::OutMost_Input_2.c_str(), a_submoduleb, A_SubModuleB::Input_AB1.c_str());
	AddCoupling(a_submoduleb, A_SubModuleB::Output_B11111111111111.c_str(), this, Outmost::OutMost_Output_1.c_str());
	// [EndRegion] Couplings
}

Outmost::~Outmost()
{
	// Destructor
}
