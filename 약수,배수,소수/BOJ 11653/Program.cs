int num = int.Parse(Console.ReadLine());

if (num == 1)
    return;

bool more = true;

while (true)
{
    if (!more)
        break;

    more = false;

    int prime = 0;

    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            prime = i;
            more = true;
            System.Console.WriteLine(prime);
            num /= prime;
            break;
        }
    }
}

System.Console.WriteLine(num);