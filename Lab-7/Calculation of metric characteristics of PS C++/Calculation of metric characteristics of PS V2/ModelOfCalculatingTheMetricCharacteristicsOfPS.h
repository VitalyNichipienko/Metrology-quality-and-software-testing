#pragma once


class ModelOfCalculatingTheMetricCharacteristicsOfPS
{
private:

    int i = 0;
    double k = 0;
    double k_ = 0;
    double s = 0;
    double n = 0;
    double Nk = 0;
    double Vk = 0;
    double v = 0;
    double p = 0;
    double tk = 0;
    double b0 = 0;
    double tao = 0;
    double ti = 0;



public:

    ModelOfCalculatingTheMetricCharacteristicsOfPS(int n2, int n2k, int n1, int nu);



    int GetI();

    double GetK();

    double GetK_();

    double GetN();

    double GetV();

    double GetP();

    double GetTk();

    double GetB0();

    double GetTi();
};

