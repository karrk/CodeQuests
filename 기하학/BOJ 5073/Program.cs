while (true)
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    if(arr[0] == arr[1] && arr[0] == arr[2])
    {
        if(arr[0] == 0)
            break;

        System.Console.WriteLine("Equilateral");
        continue;
    }

    int max = arr.Max();
    int sum = arr.Sum() - max;

    if(sum <= max)
    {
        System.Console.WriteLine("Invalid");
        continue;
    }

    if(arr[0] == arr[1] || arr[0] == arr[2] || arr[1] == arr[2])
        System.Console.WriteLine("Isosceles");
    else
        System.Console.WriteLine("Scalene");

}