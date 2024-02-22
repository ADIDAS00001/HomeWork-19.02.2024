


int cnt=0;
int Num(int a)
{
    if(a==0)
    {
        return cnt;
    }
    else 
    {
        cnt+=a%10;
        return Num(a/10);
    }
}

System.Console.WriteLine(Num(123)); 