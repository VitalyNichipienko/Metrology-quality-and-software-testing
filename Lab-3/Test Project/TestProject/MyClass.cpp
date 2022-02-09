#include "MyClass.h"
#include <iostream>
#include <string>


tuple<int, int, int> MyClass::ArrangeNumbers(int x, int y, int z)
{
	int first = min(x, min(y, z));
	int second = max(max(min(x, y), min(y, z)), min(x, z));
	int third = max(max(x, y), z);

	return tuple<int, int, int>(third, second, first);
}


int MyClass::FindGreatestCommonDivisor(int a, int b)
{
	int div;

	if (a == b)
	{
		return a;
	}

	int d = a - b;

	if (d < 0)
	{
		d = -d;
		div = FindGreatestCommonDivisor(a, d);
	}
	else
	{
		div = FindGreatestCommonDivisor(b, d);
	}

	return div;
}


int MyClass::FormNumber(int a)
{
	string result = "";

	string inputStr = to_string(a);

	for (int i = 0; i < inputStr.size(); i++)
	{
		if ((int)inputStr[i] % 2 == 0)
		{
			result += inputStr[i];
		}
	}

	return stoi(result);
}


float MyClass::SumOddElemintsTopMatrix(int(*numbers)[3], int rowsCount)
{
	float result = 0.0f;
	int columnsCount = sizeof(*numbers) / sizeof(*numbers[0]);

	for (int i = 0; i < rowsCount; i++)
	{
		for (int j = i + 1; j < columnsCount; j++)
		{
			if (numbers[i][j] % 2 != 0)
			{
				result += numbers[i][j];
			}
		}
		cout << endl;
	}

	return result;
}
