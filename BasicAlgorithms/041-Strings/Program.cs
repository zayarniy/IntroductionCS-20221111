//ReadLn(a,b,c)
//10 20 30

/*string s=Console.ReadLine();
string[] ss=s.Split(' ');
int[] n=new int[ss.Length];
for(int i=0;i<ss.Length;i++)
  n[i]=Convert.ToInt32(ss[i]);
int a=n[0];
int b=n[1];
int c=n[2];
*/

string[] ss=Console.ReadLine().Split(' ');
int[] n=Array.ConvertAll<string,int>(ss,Convert.ToInt32);//обобщенные типы и параметризированные методы
int a=n[0];
int b=n[1];
int c=n[2];

