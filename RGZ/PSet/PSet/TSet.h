#pragma once
#include <set>
#include <algorithm>
#include <iostream>

using namespace std;


class TSet
{
public:
	TSet() {	}



	void Clear();
	void Add(char item);
	void Remove(char item);
	bool Empty();
	bool Belongs(char item);
	TSet Union(TSet tset);
	TSet Difference(TSet tset);
	TSet Intersection(TSet tset);
	int Size();
	char Elem(int index);

private:
	set <char> set;
};
