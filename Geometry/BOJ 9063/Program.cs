int count = int.Parse(Console.ReadLine());

int min_x = int.MaxValue, min_y = int.MaxValue;
int max_x = int.MinValue, max_y = int.MinValue;

for (int i = 0; i < count; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    if (input[0] < min_x)
        min_x = input[0];
    if (input[1] < min_y)
        min_y = input[1];

    if (input[0] > max_x)
        max_x = input[0];
    if (input[1] > max_y)
        max_y = input[1];
}

if (count <= 1)
{
    System.Console.WriteLine(0);
    return;
}


int square = Math.Abs(max_x - min_x) * Math.Abs(max_y - min_y);

System.Console.WriteLine(square);