

void Num(int a,int b)
{
    if(b==0)
    {
        return ;
    }
    else
    {
        Num(b-1,a);
        System.Console.WriteLine($"The value of {a} to the power of {b} is : {a*a}");
    }
}
Num(5,3);