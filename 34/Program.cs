//Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int SumPositive(int[] a)
{
    int s=0;
    foreach(int el in a)
        if (el>0) s=s+el;
    return s;
}

int SumNegative(int[] a)
{
    int s=0;
    foreach(int el in a)
        if (el<0) s=s+el;
    return s;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(12,-9,9);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных {SumPositive(a)}");
System.Console.WriteLine($"Сумма отрицательных {SumNegative(a)}");