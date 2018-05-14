#include "[Name].h"

std::string [Name]::[Port] = "Port Name";

[Name]::[Name]()
{
	SetName([Model Name]);

	// Input
	AddInPorts(1, [Port].c_str());

	// Output
	AddOutPorts(1, [Port].c_str());

	// Model
	CModel* pModel_1 = new [SubModel_1]();
	AddComponent(1, pModel_1);

	CModel* pModel_2 = new [SubModel_2]();
	AddComponent(1, pModel_2);

	// Coupling
	// EIC
	AddCoupling(pModel_1, [SubModel_1]::[Port].c_str(), this, [Name]::[Port].c_str());

	// EOC
	AddCoupling(this, [Name]::[Port].c_str(), pModel_2, [SubModel_2]::[Port].c_str());

	// IC
	AddCoupling(pModel_1, [SubModel_1]::[Port].c_str(), pModel_2, [SubModel_2]::[Port].c_str());

}


[Name]::~[Name]()
{
}
