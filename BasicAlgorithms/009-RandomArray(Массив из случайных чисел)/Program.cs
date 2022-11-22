//Массив из случайных чисел

/*
int[] RandomIntArray(int size=10,int min=0,int max=100)
{
    int[] a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);
    return a;
}
*/

void RandomIntArray(out int[] a, int size=10,int min=0,int max=100)
{
    a=new int[size];
    Random random=new Random();
    for(int i=0;i<size;i++)
        a[i]=random.Next(min,max);    
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}



int[] m;
RandomIntArray(out m,max:110,size:20);
Print(m);

//