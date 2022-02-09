#include "Algorithms.h"
#include <limits.h>
#include <iostream>

using namespace std;


tuple<int, int> Algorithms::FindMinInArray(int* array, int size)
{
	int min = INT_MAX;
	int index = 0;

	for (int i = 0; i < size; i++)
	{
		if (array[i] < min)
		{
			min = array[i];
			index = i;
		}
	}

	return tuple<int, int>(min, index);
}

int* Algorithms::BubbleSort(int* array, int size)
{
	for (int i = 0; i < size; i++)
	{
		for (int j = i + 1; j < size; j++)
		{
			if (array[i] > array[j])
			{
				int temp = array[i];
				array[i] = array[j];
				array[j] = temp;
			}
		}
	}

	return array;
}


int Algorithms::BinarySearch(int array[], int size, int elem)
{
	int left = 0, right = size, mid = 0;

	while (left <= right)
	{
		mid = left + (right - left) / 2;
		if (elem < array[mid])
			right = mid - 1;
		else
			if (elem > array[mid])
				left = mid + 1;
			else 
				return mid;
	}

	return -1;
}


tuple<int, int> Algorithms::FindMinInMatrix(int(*matrix)[4], int rows)
{
	int columns = sizeof(*matrix) / sizeof(*matrix[0]);
	int min = INT_MAX;
	int index = 0;

	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			if (matrix[i][j] < min)
			{
				min = matrix[i][j];
				index = i;
			}
		}
	}

	return tuple<int, int>(min, index);
}


int* Algorithms::ReverseArray(int* array, int size)
{
	for (int i = 0, j = size - 1; i < j; i++, j--)
	{
		int t = array[i];
		array[i] = array[j];
		array[j] = t;
	}

	return array;
}


int* Algorithms::ShiftArrayElements(int* array, int size, int shiftParameter)
{
	int *newArray = new int[size];

	for (int i = 0; i < size; i++)
	{
		newArray[i] = array[(i + shiftParameter) % size];
	}

	return newArray;
}


int* Algorithms::ReplaceElements(int* array, int size, int elem, int value)
{
	for (int i = 0; i < size; i++)
	{
		if (array[i] == elem)
		{
			array[i] = value;
		}
	}

	return array;
}
