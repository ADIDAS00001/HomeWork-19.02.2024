


void Fib(int a)
{
    if(a==0 || a==1)
    {
        return ;
    }
    else
    {
        return Fib(a-1)+Fib(a-2);
    }
}
Fib(10);