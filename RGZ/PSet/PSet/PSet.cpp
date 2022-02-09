#include <iostream>
#include "TSet.h"

using namespace std;


int main()
{
	/*TSet tset;

	tset.Add(1);
	tset.Add(2);
	tset.Add(3);
	tset.Add(4);
	tset.Add(5);

	TSet tset2;

	tset2.Add(10);
	tset2.Add(20);
	tset2.Add(30);
	tset2.Add(40);
	tset2.Add(4);
	tset2.Add(5);
	tset2.Remove(40);

	cout << "set 1 " << endl;
	for (int i = 0; i < tset.Size(); i++)
		cout << tset.Elem(i) << endl;

	cout << "\nset 2 " << endl;
	for (int i = 0; i < tset2.Size(); i++)
		cout << tset2.Elem(i) << endl;

	cout << "\nUnion" << endl;
	TSet tset3 = tset2.Union(tset);
	for (int i = 0; i < tset3.Size(); i++)
		cout << tset3.Elem(i) << endl;

	cout << "\nDifference" << endl;
	TSet tset4 = tset2.Difference(tset);
	for (int i = 0; i < tset4.Size(); i++)
		cout << tset4.Elem(i) << endl;

	cout << "\nIntersection" << endl;
	TSet tset5 = tset2.Intersection(tset);
	for (int i = 0; i < tset5.Size(); i++)
		cout << tset5.Elem(i) << endl;

	cout << "\nSize set5" << endl;
	cout << tset5.Size() << endl;

	cout << "\nElem 0 set5" << endl;
	cout << tset5.Elem(0) << endl;

	cout << "\nset5 empty?" << endl;
	cout << tset5.Empty() << endl;

	cout << "\nset5 belongs 5?" << endl;
	cout << tset5.Belongs(5) << endl;*/

	double N = 94;
	double n = 68;
	double n_2 = 8;

	double S = 18;

	double V;
	double V_;
	double A;

	double length = 0;
	length = 0.91 * n * log(n);

	V = N * log2(n);
	V_ = (2 + n_2) * log2(2 + n_2);

	double L = V_ / V;

	//A = pow(L, 2) * V;
	A = pow(V_, 2) / V;

	double T = pow(V_, 3) / (S * pow(A, 2));

	double B0 = V / 3000;

	cout << "length " << length << endl;
	cout << "T " << T << endl;
	cout << "A " << A << endl;
	cout << "B0 " << B0 << endl;
	cout << "V* " << V_ << endl;
	cout << "V " << V << endl;
}