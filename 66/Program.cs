//Написать подпрограмму, которая в квадратной матрице чисел находит сумму
// элементов главной диагонали

int[,] Create2DArray(int n,int m)
{
    int[,] a=new int[n,m];
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=i+j;
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

int SumMainDiagonal(int[,] a)
{
    int s=0;
    if (a.GetLength(0)!=a.GetLength(1))
         throw new ArgumentException("Матрица не квадратная");
    for(int i=0;i<a.GetLength(0);i++)            
        s+=a[i,i];
    return s;
}

int[,] a=Create2DArray(4,6);
Print2DArray(a);
try
{
    System.Console.WriteLine(SumMainDiagonal(a));
}
catch(Exception ex)
{
    System.Console.WriteLine(ex.Message);
}