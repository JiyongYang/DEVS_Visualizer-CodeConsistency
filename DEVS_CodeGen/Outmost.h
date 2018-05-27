#include "DEVSim.h"
#include <string>

class Outmost : public CCoupled
{
public:
	Outmost();
	~Outmost();

public:
	// [Region] Ports
	static std::string OutMost_Input_1;
	static std::string OutMost_Input_2;
	static std::string OutMost_Output_1;
	// [EndRegion] Ports
};
