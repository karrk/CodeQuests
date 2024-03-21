int input = int.Parse(Console.ReadLine());

int[] arr = new int[input+2];

arr[1] = 1 % 15746;

for (int i = 2; i < arr.Length; i++)
{
    arr[i] = (arr[i-2] + arr[i-1]) % 15746;
}

System.Console.WriteLine(arr[arr.Length-1]);