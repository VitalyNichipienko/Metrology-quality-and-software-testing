#include "CppUnitTest.h"
#include "C:\Users\Виталий\source\repos\TestProject\TestProject\MyClass.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace ProjectTests
{
	TEST_CLASS(ProjectTests)
	{
	public:
		
		TEST_METHOD(METHOD_ArrangeNumbers_1)
		{
			tuple<int, int, int> actual = MyClass::ArrangeNumbers(1, 3, 2);
			tuple<int, int, int> expected(3, 2, 1);
			
			Assert::AreEqual(get<0>(expected), get<0>(actual));
			Assert::AreEqual(get<1>(expected), get<1>(actual));
			Assert::AreEqual(get<2>(expected), get<2>(actual));			
		}

		TEST_METHOD(METHOD_ArrangeNumbers_2)
		{
			tuple<int, int, int> actual = MyClass::ArrangeNumbers(1, 1, 1);
			tuple<int, int, int> expected(1, 1, 1);

			Assert::AreEqual(get<0>(expected), get<0>(actual));
			Assert::AreEqual(get<1>(expected), get<1>(actual));
			Assert::AreEqual(get<2>(expected), get<2>(actual));
		}


		TEST_METHOD(METHOD_ArrangeNumbers_3)
		{
			tuple<int, int, int> actual = MyClass::ArrangeNumbers(3, 2, 1);
			tuple<int, int, int> expected(3, 2, 1);

			Assert::AreEqual(get<0>(expected), get<0>(actual));
			Assert::AreEqual(get<1>(expected), get<1>(actual));
			Assert::AreEqual(get<2>(expected), get<2>(actual));
		}


		TEST_METHOD(METHOD_FindGreatestCommonDivisor_1)
		{
			int actual = MyClass::FindGreatestCommonDivisor(5, 20);
			int expected = 5;

			Assert::AreEqual(expected, actual);
		}


		TEST_METHOD(METHOD_FindGreatestCommonDivisor_2)
		{
			int actual = MyClass::FindGreatestCommonDivisor(11, 7);
			int expected = 1;

			Assert::AreEqual(expected, actual);
		}


		TEST_METHOD(METHOD_FormNumber)
		{
			int actual = MyClass::FormNumber(123456789);
			int expected = 2468;

			Assert::AreEqual(expected, actual);
		}


		TEST_METHOD(METHOD_SumOddElemintsTopMatrix)
		{
			int c[3][3] = { {1, 2, 3}, {4, 5, 6}, {7, 8, 9} };

			int rowsCount = sizeof(c) / sizeof(c[0]);

			float actual = MyClass::SumOddElemintsTopMatrix(c, 3);
			float expected = 3.0f;

			Assert::AreEqual(expected, actual);
		}
	};
}
