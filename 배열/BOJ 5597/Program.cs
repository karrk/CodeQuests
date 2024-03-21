int[] arr = new int[31];

for (int i = 1; i < arr.Length-2; i++)
{
    int a = int.Parse(Console.ReadLine());

    arr[a] = -1;
}

for (int i = 1; i < arr.Length; i++)
{
    if(arr[i]==0)
        System.Console.WriteLine(i);
}