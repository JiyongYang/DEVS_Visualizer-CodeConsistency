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
	~Coupled_test()
	{
	}
};
