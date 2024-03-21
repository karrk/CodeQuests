Sort(int.Parse(Console.ReadLine()));

void Sort(int count)
{
    int[] arr = new int[count];
    bool isChanged;

    for (int i = 0; i < count; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }

    int lastPoint = 0;

    while (true)
    {
        isChanged = false;

        for (int i = 1; i < count - lastPoint; i++)
        {
            if(arr[i] < arr[i-1])
            {
                int temp = arr[i];
                arr[i] = arr[i-1];
                arr[i-1] = temp;

                if(!isChanged)
                    isChanged = true;
            }
        }

        if(!isChanged)
            break;

        lastPoint++;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
}