//46. В одномерном массиве из 123 чисел найти
//количество элементов из отрезка [10,99]


int[] RandomIntArray(int N,int min,int max)
{
    int[] a=new int[N];
    //Заполнили массив
    Random random=new Random();
    for(int i=0;i<a.Length;i++)
        a[i]=random.Next(0,200);
    return a;
}

void PrintArray(int[] a,int tab=5)
{
    string formatString="{0,"+tab+"}";
    for(int i=0;i<a.Length;i++)
        System.Console.Write(formatString,a[i]);
}

void Swap(ref int a,ref int b)
{
    int t=a;
    a=b;
    b=t;
}

void Reverse(int[] a)
{
    int t;
    for(int i=0;i<a.Length/2;i++)
     Swap(ref a[i],ref a[a.Length-1-i]);
}

//Создали массив
int M=10;
int[] a=RandomIntArray(M,0,200);
PrintArray(a,5);
//Обработка массива
Reverse(a);
//a=a.Reverse().ToArray();
System.Console.WriteLine();
PrintArray(a,5);


