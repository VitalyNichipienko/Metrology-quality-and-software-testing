#include "ModelOfCalculatingTheMetricCharacteristicsOfPS.h"
#include <math.h>



ModelOfCalculatingTheMetricCharacteristicsOfPS::ModelOfCalculatingTheMetricCharacteristicsOfPS(int n2, int n2k, int n1, int nu)
{
    k = n2 / 8.0;

    i = (int)trunc((log(n2) / 3) + 1);

    for (int j = 2; j <= i; j++)
    {
        k_ += n2 / pow(8, i - 1);
    }
    k_++;

    Nk = 2 * n2k * log(n2k);

    n = k_ * Nk;

    Vk = Nk * log(2 * n2k);

    v = k_ * Vk;

    p = (3.0 / 8.0) * n;

    tk = p / (n1 * nu);

    b0 = v / 3000;

    tao = 0.5 * tk;

    ti = tao / log(b0);
}



int ModelOfCalculatingTheMetricCharacteristicsOfPS::GetI()
{
	return i;
}


double ModelOfCalculatingTheMetricCharacteristicsOfPS::GetK()
{
	return k;
}


double ModelOfCalculatingTheMetricCharacteristicsOfPS::GetK_()
{
	return k_;
}


double ModelOfCalculatingTheMetricCharacteristicsOfPS::GetN()
{
	return n;
}


double ModelOfCalculatingTheMetricCharacteristicsOfPS::GetV()
{
	return v;
}


double ModelOfCalculatingTheMetricCharacteristicsOfPS::GetP()
{
	return p;
}


double ModelOfCalculatingTheMetricCharacteristicsOfPS::GetTk()
{
	return tk;
}


double ModelOfCalculatingTheMetricCharacteristicsOfPS::GetB0()
{
	return b0;
}


double ModelOfCalculatingTheMetricCharacteristicsOfPS::GetTi()
{
	return ti;
}
