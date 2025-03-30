using System.Numerics;

for (int i = 0; i < 3; i++)
{
    int count = int.Parse(Console.ReadLine());
    BigInteger sum = 0;

    for (int j = 0; j < count; j++)
    {
        sum += BigInteger.Parse(Console.ReadLine());
    }

    if (sum == 0)
        Console.WriteLine('0');
    else if (sum > 0)
        Console.WriteLine('+');
    else
        Console.WriteLine('-');
}