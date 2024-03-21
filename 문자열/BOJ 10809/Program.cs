string input = Console.ReadLine();

int[] arr = new int[26];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -1;
}

for (int i = 0; i < input.Length; i++)
{
    int target = input[i]-'a';
    if(arr[target] == -1)
        arr[target] = i;
}

foreach (var item in arr)
{
    System.Console.Write($"{item} ");
}