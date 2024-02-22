

int e=0,o=0,z=0,d=0,mn=99999,mx=-99999,s=0;
int EvenCount(int a)
{
    for (int i=a; i>0; i/=10)
    {
        if(i%10%2==0 && i%10!=0)
        {
            e++;
        }
    }
    System.Console.Write("Even : ");
    return e;
}
Console.WriteLine(EvenCount(12043));

int OddCount(int a)
{
    for (int i=a; i>0; i/=10)
    {
        if(i%10%2!=0)
        {
            o++;
        }
    }
    System.Console.Write("Odd : ");
    return o;
}
Console.WriteLine(OddCount(12043));

int ZeroCount(int a)
{
    for (int i=a; i>0; i/=10)
    {
        if(i%10==0)
        {
            z++;
        }
    }
    System.Console.Write("Zeros : ");
    return z;
}
Console.WriteLine(ZeroCount(12043));

int DigitCount(int a)
{
    for (int i=a; i>0; i/=10)
    {
        d++;
    }
    System.Console.Write("Digits : ");
    return d;
}
Console.WriteLine(DigitCount(12043));

int MinDigit(int a)
{
    for (int i=a; i>0; i/=10)
    {
        if(i%10<mn)
        {
            mn=i%10;
        }
    }
    System.Console.Write("Min : ");
    return mn;
}
Console.WriteLine(MinDigit(12043));

int MaxDigit(int a)
{
    for (int i=a; i>0; i/=10)
    {
        if(i%10>mx)
        {
            mx=i%10;
        }
    }
    System.Console.Write("Max : ");
    return mx;
}
Console.WriteLine(MaxDigit(12043));

int SumDigit(int a)
{
    for (int i=a; i>0; i/=10)
    {
        s+=i%10;
    }
    System.Console.Write("Sum of Digits : ");
    return s;
}
Console.WriteLine(SumDigit(12043));