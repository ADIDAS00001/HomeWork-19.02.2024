

int Pow(int a,int b)
{
    if(b==0)
    {
        return 1;
    }
    else
    {
        return a*Pow(a,b-1);
    }
}
System.Console.Write("Input the base value : ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input the exponent : ");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Pow(a,b));
