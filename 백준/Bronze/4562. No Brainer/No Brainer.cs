int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    if (arr[0] < arr[1])
        Console.WriteLine("NO BRAINS");
    else
        Console.WriteLine("MMM BRAINS");
}