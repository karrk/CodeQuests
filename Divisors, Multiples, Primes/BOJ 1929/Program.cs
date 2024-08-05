using System.Text;

StringBuilder sb = new StringBuilder();

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int[] arr = new int[input[1]+1];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
}

for (int i = 2; i < arr.Length; i++)
{
    if(arr[i] == -1)
        continue;

    for (int j = 2; i*j < arr.Length; j++)
    {
        if(arr[i*j] != -1)
            arr[i*j] = -1;
    }
}

int start = input[0] == 1 ? input[0] + 1 : input[0];

for (int i = start; i < arr.Length; i++)
{
    if(arr[i] == -1)
        continue;

    sb.AppendLine($"{arr[i]}");
}

System.Console.WriteLine(sb.ToString());