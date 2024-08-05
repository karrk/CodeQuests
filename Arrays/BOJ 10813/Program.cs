string[] input = Console.ReadLine().Split(' ');

int[] arr = new int[int.Parse(input[0])];
int count = int.Parse(input[1]);

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
}

for (int i = 0; i < count; i++)
{
    input = Console.ReadLine().Split(' ');

    int x = int.Parse(input[0])-1;
    int y = int.Parse(input[1])-1;

    int temp = arr[x];
    arr[x] = arr[y];
    arr[y] = temp;
}

foreach (var item in arr)
{
    System.Console.Write($"{item+1} ");
}
