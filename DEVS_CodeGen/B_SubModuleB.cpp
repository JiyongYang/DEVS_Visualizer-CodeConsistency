#include "B_SubModuleB.h"

// [Region] Ports_init
std::string B_SubModuleB::Input_C1 = "Input_C1";
std::string B_SubModuleB::Input_C2 = "Input_C2";
std::string B_SubModuleB::Output_C1 = "Output_C1";
// [EndRegion] Ports_init
B_SubModuleB::B_SubModuleB()
{
	// Constructor
	SetName("B_SubModuleB");

	// [Region] Ports_reg
	// Input ports
	AddInPorts(1, Input_C1.c_str());
	AddInPorts(1, Input_C2.c_str());
	// Output Ports
	AddOutPorts(1, Output_C1.c_str());
	// [Region] Ports_reg
}

B_SubModuleB::~B_SubModuleB()
{
	// Destructor
}

bool B_SubModuleB::ExtTransFn(const CDEVSimMessage & msg)
{
	return ;
}

bool B_SubModuleB::IntTransFn()
{
	return ;
}

bool B_SubModuleB::OutputFn(CDEVSimMessage & msg)
{
	return ;
}

bool B_SubModuleB::TimeAdvanceFn()
{
	return ;
}

