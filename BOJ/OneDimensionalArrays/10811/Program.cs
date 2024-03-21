string[] input = Console.ReadLine().Split(' ');

int[] arr = new int[int.Parse(input[0])+1];
int total = int.Parse(input[1]);

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
}

for (int i = 0; i < total; i++)
{
    input = Console.ReadLine().Split(' ');

    int x = int.Parse(input[0]);
    int y = int.Parse(input[1]);

    for (int j = 0; j <= ((y-x)/2); j++)
    {
        int temp = arr[x+j];
        arr[x+j] = arr[y-j];
        arr[y-j] = temp;
    }
}

for (int i = 1; i < arr.Length; i++)
{
    System.Console.Write($"{arr[i]} ");
}

