//Списки

List<int> temp;
temp=new List<int>();
for(int i=0;i<7;i++)
    temp.Add(Convert.ToInt32(Console.ReadLine()));
double s=0;
for(int i=0;i<7;i++)
    s=s+temp[i];
System.Console.WriteLine(s/temp.Count);    
