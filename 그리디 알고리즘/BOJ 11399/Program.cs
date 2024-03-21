int count = int.Parse(Console.ReadLine());
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

for (int i = 1; i < count; i++)
{
    int selectedData = arr[i];
    int insertPointer = i;

    for (int j = i-1; j >= 0; j--)
    {
        if(arr[j] > selectedData)
        {
            insertPointer--;
            arr[j+1] = arr[j];
        }
        else
            break;
    }

    arr[insertPointer] = selectedData;
}

for (int i = 1; i < count; i++)
{
    arr[i] += arr[i-1];
}

System.Console.WriteLine(arr.Sum());