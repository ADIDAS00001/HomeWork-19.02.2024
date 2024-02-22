

System.Console.Write("The first number is: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("The operation is: ");
char b=Convert.ToChar(Console.ReadLine());
System.Console.Write("The last number is : ");
int c=Convert.ToInt32(Console.ReadLine());
if(b=='+')
{
    System.Console.WriteLine($"{a} {b} {c} = {a+c}");
}
else if(b=='-')
{
    System.Console.WriteLine($"{a} {b} {c} = {a-c}");
}
else if(b=='*')
{
    System.Console.WriteLine($"{a} {b} {c} = {a*c}");
}
else if(b=='/')
{
    System.Console.WriteLine($"{a} {b} {c} = {a/c}");
}