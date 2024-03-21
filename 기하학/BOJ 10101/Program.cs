int[] arr = new int[3];
int sum = 0;
int count = 1;

for (int i = 0; i < arr.Length; i++)
{
    int num = int.Parse(Console.ReadLine());

    sum += num;

    if(arr.Contains(num))
        count++;

    arr[i] = num;
}

if(sum != 180){
    System.Console.WriteLine("Error");
    return;
}
    

if (count == 1)
    System.Console.WriteLine("Scalene");
else if (count == 2)
    System.Console.WriteLine("Isosceles");
else
    System.Console.WriteLine("Equilateral");

