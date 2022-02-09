#pragma once
#include <tuple>

using namespace std;

class MyClass
{
public:
	static tuple<int, int, int> ArrangeNumbers(int x, int y, int z);


	static int FindGreatestCommonDivisor(int a, int b);


	static int FormNumber(int a);


	static float SumOddElemintsTopMatrix(int(*)[3], int);
};

