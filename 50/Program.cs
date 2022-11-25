//50. Выяснить являются ли три числа сторонами треугольника

bool CheckTriangle(int a,int b,int c)
{
    return a+b>c && a+c>b && b+c>a;
}

int a=4,b=4,c=5;

if (CheckTriangle(a,b,c)) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");

