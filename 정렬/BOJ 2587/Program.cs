int[] arr = new int[5];
int totalValue = 0;

for(int i = 0; i < arr.Length; i++ ){
    arr[i] = 
        int.Parse(Console.ReadLine());
    totalValue += arr[i];
}

Array.Sort(arr);

Console.WriteLine(totalValue/5);
Console.WriteLine(arr[2]);