#include "DEVSim.h"
#include <string>

class Coupled_test : public CCoupled
{
public:
	static std::string inport_1;
	static std::string inport_2;
	static std::string outport_1;
public:
	Coupled_test()
	{
	}
	inport_1 getinport_1()
	{
		return this->inport_1;
	}
	inport_2 getinport_2()
	{
		return this->inport_2;
	}
	outport_1 getoutport_1()
	{
		return this->outport_1;
	}
};
