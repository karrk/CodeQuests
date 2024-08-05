Sort(Console.ReadLine());

void Sort(string input)
{
    int[] arr = new int[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        arr[i] = int.Parse(input[i].ToString());
    }

    for (int i = 0; i < input.Length; i++)
    {
        int targetPoint = i;

        for (int j = i + 1; j < input.Length; j++)
        {
            if (arr[targetPoint] < arr[j])
                targetPoint = j;
        }

        if (targetPoint != i)
        {
            int tempValue = arr[targetPoint];
            arr[targetPoint] = arr[i];
            arr[i] = tempValue;
        }
    }

    foreach (var value in arr)
    {
        System.Console.Write(value);
    }
}