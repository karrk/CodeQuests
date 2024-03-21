string[] input = Console.ReadLine().Split(' ');

int[] arr = new int[int.Parse(input[0])];
int count = int.Parse(input[1]);

for (int i = 0; i < count; i++)
{
    input = Console.ReadLine().Split(' ');
    int x = int.Parse(input[0])-1;
    int y = int.Parse(input[1])-1;
    int z = int.Parse(input[2]);

    for (int j = x; j <= y; j++)
    {
        arr[j] = z;
    }
}

foreach (var item in arr)
{
    System.Console.Write($"{item} ");
}