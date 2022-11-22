//41. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max+1);
    return a;
}

int Max(int[] a)
{
    int m=a[0];
    for(int i=1;i<a.Length;i++)
         if (a[i]>m) m=a[i];
    return m;
}

int Min(int[] a)
{
    int m=a[0];
    for(int i=1;i<a.Length;i++)
         if (a[i]<m) m=a[i];
    return m;
}

void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int[] a=RandomIntArray(3,0,10);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine(Max(a)-Min(a));