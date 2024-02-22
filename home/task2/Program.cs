


void CheckGrade(int grade)
{
    if(grade<60)
    {
        System.Console.WriteLine("F");
    }
    else if(grade>=60 && grade<70)
    {
        System.Console.WriteLine("D");
    }
    else if(grade>=70 && grade<80)
    {
        System.Console.WriteLine("C");
    }
    else if(grade>=80 && grade<90)
    {
        System.Console.WriteLine("B");
    }
    else if(grade>=90 && grade<=100)
    {
        System.Console.WriteLine("A");
    }   
}
int grade=Convert.ToInt32(Console.ReadLine());
CheckGrade(grade);