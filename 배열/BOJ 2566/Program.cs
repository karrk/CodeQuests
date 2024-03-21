int[,] arr = new int[9,9];

int maxValue = int.MinValue;
int[] result = new int[2];

for (int i = 0; i < arr.GetLength(0); i++)
{
    string[] input = Console.ReadLine().Split(' ');

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = int.Parse(input[j]);

        if(arr[i,j] > maxValue)
        {
            maxValue = arr[i,j];
            result[0] = i+1;
            result[1] = j+1;
        }
            
    }
}

System.Console.WriteLine($"{maxValue}\n{result[0]} {result[1]}");
