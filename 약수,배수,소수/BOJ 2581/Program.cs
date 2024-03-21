int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int sum = 0;
int min = int.MaxValue;

for (int i = n; i <= m; i++)
{
    if(i == 1)
        continue;

    bool find = false;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            find = true;
            break;
        }
    }

    if (!find)
    {
        sum += i;

        if (min > i)
            min = i;
    }

}

if (sum != 0)
{
    System.Console.WriteLine(sum);
    System.Console.WriteLine(min);
}
else
    System.Console.WriteLine(-1);