
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt = 0;
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        if (arr[i] == arr[j] && i != j) 
        {
            cnt++;
        }
    }
    if (cnt != 0)
    {
        System.Console.Write(arr[i] + " "); 
    }
    cnt = 0;
}