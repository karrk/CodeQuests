int count = int.Parse(Console.ReadLine());

int[,] arr = new int[100,100];

for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    int left = int.Parse(input[0]);
    int bottom = int.Parse(input[1]);

    for (int j = left; j < left+10; j++)
    {
        for (int k = bottom; k < bottom+10; k++)
        {
            arr[j,k] = 1;
        }
    }
}

int result = 0;

foreach (var item in arr)
{
    result += item;
}

System.Console.WriteLine(result);