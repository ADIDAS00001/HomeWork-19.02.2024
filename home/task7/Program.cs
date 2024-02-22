

System.Console.Write("From = ");
int a=Convert.ToInt32(Console.ReadLine());

System.Console.Write("To = ");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("--------------------");
for (int i = a; i <=b; i++)
{
   for (int j = 1; j <=10; j++)
   {
        System.Console.Write($"{i}*{j}={i*j}");
        Console.WriteLine();
   }
   System.Console.WriteLine("--------------------");
}
