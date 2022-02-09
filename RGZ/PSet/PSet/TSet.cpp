#include "TSet.h"


void TSet::Clear()
{
	set.clear();
}


void TSet::Add(char item)
{
	set.insert(item);
}


void TSet::Remove(char item)
{
	set.erase(item);
}


bool TSet::Empty()
{
	if (set.empty())
	{
		return true;
	}
	else
	{
		return false;
	}
}


bool TSet::Belongs(char item)
{
	if (set.find(item) != set.end())
	{
		return true;
	}
	else
	{
		return false;
	}
}


TSet TSet::Union(TSet tset)
{
	std::set <char> newSet;

	for (int i = 0; i < tset.Size(); i++)
	{
		newSet.insert(tset.Elem(i));
	}

	std::set<char> unionSet;
	set_union(set.begin(), set.end(), newSet.begin(), newSet.end(),
		std::inserter(unionSet, unionSet.begin()));

	TSet newTSet;

	for (auto i : unionSet)
	{
		newTSet.Add(i);
	}

	return newTSet;
}


TSet TSet::Difference(TSet tset)
{
	std::set <char> newSet;

	for (int i = 0; i < tset.Size(); i++)
	{
		newSet.insert(tset.Elem(i));
	}

	std::set<char> differenceSet;
	set_difference(set.begin(), set.end(), newSet.begin(), newSet.end(),
		std::inserter(differenceSet, differenceSet.begin()));

	TSet newTSet;

	for (auto i : differenceSet)
	{
		newTSet.Add(i);
	}

	return newTSet;
}


TSet TSet::Intersection(TSet tset)
{
	std::set <char> newSet;

	for (int i = 0; i < tset.Size(); i++)
	{
		newSet.insert(tset.Elem(i));
	}

	std::set<char> intersectionSet;
	set_intersection(set.begin(), set.end(), newSet.begin(), newSet.end(),
		std::inserter(intersectionSet, intersectionSet.begin()));

	TSet newTSet;

	for (auto i : intersectionSet)
	{
		newTSet.Add(i);
	}

	return newTSet;
}


int TSet::Size()
{
	return set.size();
}


char TSet::Elem(int index)
{
	std::set<char>::iterator it = set.begin();
	advance(it, index);

	char elem = *it;

	return elem;
}
