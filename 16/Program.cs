//16. Дано число. Проверить кратно ли оно 7 и 23
int n=Convert.ToInt32(Console.ReadLine());
bool d1=n%7==0;
bool d2=n%23==0;
if (d1 && d2) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");
