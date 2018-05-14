#include "Coupled_test.h"

std::string Coupled_test::inport_1 = "inport_1"
std::string Coupled_test::inport_2 = "inport_2"
std::string Coupled_test::outport_1 = "outport_1"

Coupled_test::Coupled_test
{
	SetName("[Model Name]");
	// IN Ports
	AddInPorts(1, [Port Name].c_str());
	// OUT Ports
	AddOutPorts(1, [Port Name].c_str());
};
~Coupled_test::Coupled_test
{
	//Destructor
};
