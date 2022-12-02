//76. Написать программу возведения числа А в целую положительную степень B

double Power(int a,int b)
{
    if (b>0) return Power(a,b-1)*a;
        else
            if (b<0) return Power(a,b+1)*1/a;
                else return 1;
}

System.Console.WriteLine(Power(2,-3));