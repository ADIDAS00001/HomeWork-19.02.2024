


int  a=Convert.ToInt32(Console.ReadLine());
int cnt=0;
int sum=0,cnt1=0;
for (int i = a; i > 0; i/=10)
{
    cnt++;
    cnt1+=i%10;
    sum=cnt1/cnt;
}
System.Console.WriteLine(sum);