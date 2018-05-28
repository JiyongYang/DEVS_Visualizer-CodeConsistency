#include "DEVSim.h"
#include <string>

class B_SubModuleB : public CAtomic
{
public:
	B_SubModuleB();
	~B_SubModuleB();

public:
	virtual bool ExtTransFn(const CDEVSimMessage &);
	virtual bool IntTransFn();
	virtual bool OutputFn(CDEVSimMessage &);
	virtual TimeType TimeAdvanceFn();

public:
	// [Region] Ports
	static std::string Input_C1;
	static std::string Input_C2;
	static std::string Output_C1;
	// [EndRegion] Ports
};
