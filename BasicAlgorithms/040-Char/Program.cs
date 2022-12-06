
using System.Linq;

char c='a';
c='\x0064';
c='\u0064';
char b='a';
System.Console.WriteLine((int)b);
System.Console.WriteLine(c.ToString()+b.ToString());
if (b>='0' && b<='9') System.Console.WriteLine("It's digit");
if (b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");
if (b>='a' && b<='z' || b>='A' && b<='Z') System.Console.WriteLine("It's big Latin");

if (Char.IsDigit(b)) System.Console.WriteLine("It's digit");


