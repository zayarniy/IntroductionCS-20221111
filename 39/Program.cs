//39. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int SumOddPositions(int[] a)
{
    int s=0;
    for(int i=1;i<a.Length;i+=2)
         s=s+a[i];
    return s;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(3,0,10);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(SumOddPositions(a));