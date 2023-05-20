#include "Includes.h"

bool isSameCity(City c1, City c2) {
	string name1, name2;
	name1 = c1.getName();
	name2 = c2.getName();
	if (name1 == name2)
	{
		return true;
	}
	return false;
}

void population(string& pop, City& c1, City& c2) {
	size_t population(0), p1(c1.getPopulation()), p2(c2.getPopulation());
	if (c1.getCensusYear() <= c2.getCensusYear() && c1.getPopulation() > c2.getPopulation())
	{
		pop = "-" + to_string(c1.getPopulation() - c2.getPopulation());
	}
	else if (c1.getCensusYear() <= c2.getCensusYear() && c1.getPopulation() < c2.getPopulation())
	{
		pop = "+" + to_string(c2.getPopulation() - c1.getPopulation());
	}
	else if (c1.getCensusYear() > c2.getCensusYear() && c1.getPopulation() > c2.getPopulation())
	{
		//2020 - 2012 -> 20 - 3
		pop = "+" + to_string(c1.getPopulation() - c2.getPopulation());
	}
	else if (c1.getCensusYear() > c2.getCensusYear() && c1.getPopulation() < c2.getPopulation())
	{
		//2020 - 2012 -> 3 - 30
		pop = "-" + to_string(c2.getPopulation() - c1.getPopulation());
	}
}

class CityDiff {
private:
	string vr;
public:
	CityDiff(string vr) : vr(vr) {}
	string returnvr() { return vr; }
};

CityDiff operator- (City& c1, City& c2) {
	if (isSameCity(c1, c2))
	{
		string name(c1.getName()), pop, vs;
		population(pop, c1, c2);
		vs = "(" + to_string(c1.getCensusYear()) + " vs. " + to_string(c2.getCensusYear()) + ")";
		string vr = name + " " + vs + "\n" + "population: " + pop + "\n";

		return CityDiff(vr);
	}
	else if (!isSameCity(c1, c2))
	{
		string	name1(c1.getName()), name2(c2.getName()), pop,
				vs1("(" + to_string(c1.getCensusYear()) + ")"), 
				vs2("(" + to_string(c2.getCensusYear()) + ")");

		population(pop, c1, c2);

		string vr = name1 + " " + vs1 + " vs." + name2 + " " + vs2 + "\n" +"population: "+ pop + "\n";

		return CityDiff(vr);
	}
}
ostream& operator << (ostream &out, CityDiff & diff) {
	out << diff.returnvr();
	return out;
}
