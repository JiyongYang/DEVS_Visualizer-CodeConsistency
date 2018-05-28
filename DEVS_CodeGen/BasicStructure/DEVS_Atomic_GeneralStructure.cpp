#include "ClockAtomic.h"
#include "MessageDef.h"

std::string [AtomicModelName]::[PortName] = "Port Name";

[AtomicModelName]::[AtomicModelName]()
{
	SetName([AtomicModelName]);

	// Input
	AddInPorts(1, [PortName].c_str());
	// Output
  AddOutPorts(1, [PortName].c_str());
}


[AtomicModelName]::~[AtomicModelName]()
{

}

bool [AtomicModelName]::ExtTransFn(const CDEVSimMessage & msg)
{
	return true;
}

bool [AtomicModelName]::IntTransFn()
{
	return true;
}

bool [AtomicModelName]::OutputFn(CDEVSimMessage & msg)
{
	return true;
}

TimeType [AtomicModelName]::TimeAdvanceFn()
{
}
