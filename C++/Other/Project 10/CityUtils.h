#pragma once
#ifndef _CITYUTILS_H
#define _CITYUTILS_H
#include "City.h"
#include<iostream>
#include<string>
#include <map>
#include <vector>
using namespace std;
const City* initCity( string &a,  size_t &population) {
	City* city  = new City(a, population);
	return city;
}

map <size_t, const City*> groupByPopulation(vector<const City*> cities, size_t &totalPopulation){
	map <size_t, const City*> ordered;
	totalPopulation = 0;
	for(const City* c:cities){
		size_t pop = c->getPopulation();
		totalPopulation += pop;
		ordered.insert(pair< size_t, const City*>(pop, c));
	}
	return ordered;
}

#endif // !_CITYUTILS_H

