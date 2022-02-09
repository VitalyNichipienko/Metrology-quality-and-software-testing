#pragma once
#include <tuple>

using namespace std;


class Algorithms
{
public:
	tuple<int, int> FindMinInArray(int* array, int size);


	int* BubbleSort(int* array, int size);


	int BinarySearch(int array[], int size, int elem);


	tuple<int, int> FindMinInMatrix(int(*)[4], int);


	int* ReverseArray(int* array, int size);


	int* ShiftArrayElements(int* array, int size, int shiftParameter);


	int* ReplaceElements(int* array, int size, int elem, int value);
};

