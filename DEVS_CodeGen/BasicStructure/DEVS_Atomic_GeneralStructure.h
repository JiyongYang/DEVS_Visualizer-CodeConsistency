#include "DEVSim.h"
#include <string>

class [AtomicModelName] : public CAtomic
{
public:
	[AtomicModelName]();
	~[AtomicModelName]();

public:
	virtual bool ExtTransFn(const CDEVSimMessage &);
	virtual bool IntTransFn();
	virtual bool OutputFn(CDEVSimMessage &);
	virtual TimeType TimeAdvanceFn();

public:
	static std::string [PortName];
};
