#include "DEVSim.h"
#include <string>

class A_SubModuleA : public CCoupled
{
public:
	A_SubModuleA();
	~A_SubModuleA();

public:
	// [Region] Ports
	static std::string Input_AA1;
	static std::string Input_AB1;
	static std::string Output_B11111111111111;
	// [EndRegion] Ports
};
