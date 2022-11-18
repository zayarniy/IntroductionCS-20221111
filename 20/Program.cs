//20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У,
// причем X ≠ 0 и Y ≠ 0

//тип имя(аргументы)


class Program
{


static int Part(double x,double y)
{
 //тело подпрограммы
    
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x<0 && y<0) return 3;
    if (x>0 && y<0) return 4;
    return 0;
}

static void Pause()
{
    System.Console.WriteLine("Press any key");    
    Console.ReadKey();
}

static void Pause(string message)//перегрузка по аргументам
{
    System.Console.WriteLine(message);    
    Console.ReadKey();
}

static void Pause(int i)
{

}

    static void Main()
    {
        double x=Convert.ToDouble(Console.ReadLine());
        double y=Convert.ToDouble(Console.ReadLine());
        int p=Part(x,y);
        System.Console.WriteLine("Part:"+p);    
        Pause("Нажмите любую клавишу");
    }
}