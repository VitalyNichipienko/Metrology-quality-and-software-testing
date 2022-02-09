#include <iostream>
#include "ModelOfCalculatingTheMetricCharacteristicsOfPS.h"

using namespace std;



int main()
{
    setlocale(LC_ALL, "Russian");

    while (true)
    {
        cout << "Enter n2" << endl;
        int n2;
        cin >> n2;
        cout << "Enter n2k" << endl;
        int n2k;
        cin >> n2k;
        cout << "Enter n1" << endl;
        int n1;
        cin >> n1;
        cout << "Enter nu" << endl;
        int nu;
        cin >> nu;

        ModelOfCalculatingTheMetricCharacteristicsOfPS model = ModelOfCalculatingTheMetricCharacteristicsOfPS(n2, n2k, n1, nu);

        cout << "\n";
        cout << "Число модулей нижнего уровня k = " << model.GetK() << endl;
        cout << "Число уровней иерархии i = " << model.GetI() << endl;
        cout << "Общее число модулей K = " << model.GetK_() << endl;
        cout << "Длина программы N = " << model.GetN() << endl;
        cout << "Объём V = " << model.GetV() << endl;
        cout << "Длина ПС P = " << model.GetP() << endl;
        cout << "Календарное время программирования Tk = " << model.GetTk() << endl;
        cout << "Начальное количество ошибок B0 = " << model.GetB0() << endl;
        cout << "Надёжность ПС ti = " << model.GetTi() << endl;
        cout << "\n\n\n";
    }
}