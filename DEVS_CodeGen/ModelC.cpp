#include "ModelC.h"

std::string ModelC::Input_C1 = "Input_C1";
std::string ModelC::Input_C2 = "Input_C2";
std::string ModelC::Output_C1 = "Output_C1";

ModelC::ModelC()
{
	// Constructor
	SetName("ModelC");

	// Input ports
	AddInPorts(1, Input_C1.c_str());
	AddInPorts(1, Input_C2.c_str());
	// Output Ports
	AddOutPorts(1, Output_C1.c_str());
}

ModelC::~ModelC()
{
	// Destructor
}

bool ModelC::ExtTransFn(const CDEVSimMessage & msg)
{
	return ;
}

bool ModelC::IntTransFn()
{
	return ;
}

bool ModelC::OutputFn(CDEVSimMessage & msg)
{
	return ;
}

bool ModelC::TimeAdvanceFn()
{
	return ;
}

