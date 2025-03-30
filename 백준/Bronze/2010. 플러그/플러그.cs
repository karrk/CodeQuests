int n = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 0; i < n; i++)
{
    result += int.Parse(Console.ReadLine());
}

Console.WriteLine(result - (n - 1));