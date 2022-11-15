//18. По двум заданным числам проверять является ли одно квадратом другого.
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
if (a*a==b) System.Console.WriteLine($"{b} является квадратом {a}");
    else
        if (b*b==a) System.Console.WriteLine($"{a} является квадратом {b}");
            else
                System.Console.WriteLine("Не является");