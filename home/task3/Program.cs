

int a=Convert.ToInt32(Console.ReadLine());
int b=0;
int n=0,p=0,z=0,e=0,o=0,mx=-99999,mn=99999,s=0;
for (int i = 1; i <=a; i++)
{
    b=Convert.ToInt32(Console.ReadLine());
    s+=b;
    if(b<=0)
    {
        n++;
    }
    if(b>0)
    {
        p++;
    }
    if(b==0)
    {
        z++;
    }
    if(b%2==0 && b!=0)
    {
        e++;
    }
    if(b%2!=0)
    {
        o++;
    }
    if(b>mx)
    {
        mx=b;
    }
    if(b<mn)
    {
        mn=b;
    }
}
System.Console.WriteLine($"Negative = {n}");
System.Console.WriteLine($"Positive = {p}");
System.Console.WriteLine($"Zeros = {z}");
System.Console.WriteLine($"Even = {e}");
System.Console.WriteLine($"Odd = {o}");
System.Console.WriteLine($"Max = {mx}");
System.Console.WriteLine($"Min = {mn}");
System.Console.WriteLine($"Sum of Digits = {s}");