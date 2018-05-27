#include "DEVSim.h"
#include <string>

class A_SubModuleB : public CCoupled
{
public:
	A_SubModuleB();
	~A_SubModuleB();

public:
	static std::string Input_AA1;
	static std::string Input_AB1;
	static std::string Output_B11111111111111;
};
