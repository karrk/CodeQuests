int count = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');

int result = 0;

for (int i = 0; i < count; i++)
{
    int num = int.Parse(input[i]);
    bool find = false;

    if(num == 1)
        continue;

    for (int j = 2; j < num; j++)
    {
        if(num % j == 0)
        {
            find = true;
            break;
        }
    }

    if(!find)
        result++;
}

System.Console.WriteLine(result);