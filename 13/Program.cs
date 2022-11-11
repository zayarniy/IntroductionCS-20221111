//13. Удалить вторую цифру целого числа введенного с клавиатуры.
int a=Convert.ToInt32(Console.ReadLine());
//345=35
//12345=1235
int b=a/100*10+a%10;
System.Console.WriteLine(b);


