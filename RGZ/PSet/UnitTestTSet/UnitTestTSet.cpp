#include "CppUnitTest.h"
#include "C:\Users\Виталий\source\repos\PSet\PSet\TSet.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;


namespace UnitTestTSet
{
	TEST_CLASS(UnitTestTSet)
	{
	public:

		TEST_METHOD(TestMethodClear)
		{
			TSet tset;
			tset.Add(0);
			Assert::IsFalse(tset.Empty());
			tset.Clear();
			Assert::IsTrue(tset.Empty());
		}


		TEST_METHOD(TestMethodAdd)
		{
			TSet tset;
			char elem = 0;
			tset.Add(elem);
			Assert::IsTrue(tset.Belongs(elem));
		}


		TEST_METHOD(TestMethodRemove)
		{
			TSet tset;
			char elem = 0;
			tset.Add(elem);
			tset.Remove(elem);
			Assert::IsFalse(tset.Belongs(elem));
		}


		TEST_METHOD(TestMethodEmptyTrue)
		{
			TSet tset;
			Assert::IsTrue(tset.Empty());
		}


		TEST_METHOD(TestMethodEmptyFalse)
		{
			TSet tset;
			char elem = 0;
			tset.Add(elem);
			Assert::IsFalse(tset.Empty());
		}


		TEST_METHOD(TestMethodBelongsTrue)
		{
			TSet tset;
			char elem = 0;
			tset.Add(elem);
			Assert::IsTrue(tset.Belongs(elem));
		}


		TEST_METHOD(TestMethodBelongsFalse)
		{
			TSet tset;
			char elem = 0;
			Assert::IsFalse(tset.Belongs(elem));
		}


		TEST_METHOD(TestMethodUnion1)
		{
			TSet tset1;
			TSet tset2;
			TSet tset3;

			tset1 = tset1.Union(tset2);

			Assert::AreEqual(tset1.Empty(), tset3.Empty());
		}


		TEST_METHOD(TestMethodUnion2)
		{
			TSet tset1;
			TSet tset2;
			TSet tset3;

			tset1.Add(0);

			tset3.Add(0);

			tset1 = tset1.Union(tset2);

			Assert::AreEqual(tset1.Size(), tset3.Size());

			for (int i = 0; i < tset1.Size(); i++)
			{
				Assert::AreEqual(tset1.Elem(i), tset3.Elem(i));
			}
		}


		TEST_METHOD(TestMethodUnion3)
		{
			TSet tset1;
			TSet tset2;
			TSet tset3;

			tset1.Add(1);

			tset2.Add(0);

			tset3.Add(1);
			tset3.Add(0);

			tset1 = tset1.Union(tset2);

			Assert::AreEqual(tset1.Size(), tset3.Size());

			for (int i = 0; i < tset1.Size(); i++)
			{
				Assert::AreEqual(tset1.Elem(i), tset3.Elem(i));
			}
		}


		TEST_METHOD(TestMethodUnion4)
		{
			TSet tset1;
			TSet tset2;
			TSet tset3;

			tset1.Add(1);
			tset1.Add(0);

			tset2.Add(1);
			tset2.Add(0);

			tset3.Add(1);
			tset3.Add(0);

			tset1 = tset1.Union(tset2);

			Assert::AreEqual(tset1.Size(), tset3.Size());

			for (int i = 0; i < tset1.Size(); i++)
			{
				Assert::AreEqual(tset1.Elem(i), tset3.Elem(i));
			}
		}


		TEST_METHOD(TestMethodUnion5)
		{
			TSet tset1;
			TSet tset2;
			TSet tset3;

			tset1.Add(1);
			tset1.Add(2);
			tset1.Add(3);

			tset2.Add(3);
			tset2.Add(4);
			tset2.Add(5);

			tset3.Add(1);
			tset3.Add(2);
			tset3.Add(3);
			tset3.Add(4);
			tset3.Add(5);

			tset1 = tset1.Union(tset2);

			Assert::AreEqual(tset1.Size(), tset3.Size());

			for (int i = 0; i < tset1.Size(); i++)
			{
				Assert::AreEqual(tset1.Elem(i), tset3.Elem(i));
			}
		}


		TEST_METHOD(TestMethodDifference)
		{
			TSet tset1;
			TSet tset2;
			TSet tset3;

			tset1.Add(1);
			tset1.Add(2);
			tset1.Add(3);

			tset2.Add(3);
			tset2.Add(4);
			tset2.Add(5);

			tset3.Add(1);
			tset3.Add(2);

			tset1 = tset1.Difference(tset2);

			Assert::AreEqual(tset1.Size(), tset3.Size());

			for (int i = 0; i < tset1.Size(); i++)
			{
				Assert::AreEqual(tset1.Elem(i), tset3.Elem(i));
			}
		}


		TEST_METHOD(TestMethodIntersection)
		{
			TSet tset1;
			TSet tset2;
			TSet tset3;

			tset1.Add(1);
			tset1.Add(2);
			tset1.Add(3);

			tset2.Add(3);
			tset2.Add(4);
			tset2.Add(5);

			tset3.Add(3);

			tset1 = tset1.Intersection(tset2);

			Assert::AreEqual(tset1.Size(), tset3.Size());

			for (int i = 0; i < tset1.Size(); i++)
			{
				Assert::AreEqual(tset1.Elem(i), tset3.Elem(i));
			}
		}


		TEST_METHOD(TestMethodSize)
		{
			TSet tset;

			tset.Add(1);
			tset.Add(2);
			tset.Add(3);

			Assert::AreEqual(tset.Size(), 3);
		}


		TEST_METHOD(TestMethodElem)
		{
			TSet tset;

			tset.Add(1);
			tset.Add(2);
			tset.Add(3);

			Assert::AreEqual(tset.Elem(0), (char)1);
		}
	};
}
