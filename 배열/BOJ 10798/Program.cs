int[,] arr = new int[5,15];

for (int i = 0; i < arr.GetLength(0); i++)
{
    string input = Console.ReadLine();

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = -1;
    }

    for (int j = 0; j < input.Length; j++)
    {
        arr[i,j] = input[j];
    }
}

for (int i = 0; i < arr.GetLength(1); i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        if(arr[j,i]==-1)
            continue;

        System.Console.Write((char)arr[j,i]);
    }
}