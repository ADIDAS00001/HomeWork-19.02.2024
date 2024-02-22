

int Fib(int a)
{
    if(a==0 || a==1)
    {
        return a;
    }
    else
    {
        return Fib(a-1)+Fib(a-2);
    }
}
System.Console.Write("Input number of terms for the Fibonacci series : ");
int a=Convert.ToInt32(Console.ReadLine());
Fib(a);
System.Console.Write($"The Fibonacci series of {a} terms is : ");
for (int i = 0; i < a; i++)
{
    System.Console.Write(Fib(i)+" ");
}