#include "DEVSim.h"
#include <string>

class ModelC : public CAtomic
{
public:
	ModelC();
	~ModelC();

public:
	virtual bool ExtTransFn(const CDEVSimMessage &);
	virtual bool IntTransFn();
	virtual bool OutputFn(CDEVSimMessage &);
	virtual TimeType TimeAdvanceFn();

public:
	static std::string Input_C1;
	static std::string Input_C2;
	static std::string Output_C1;
};
