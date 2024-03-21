int input = int.Parse(Console.ReadLine());

int count1 = 0;
int count2 = 0;

int fibo(int n)
{
    if(n <= 2)
    {
        count1++;
        return 1;
    }
        

    return fibo(n-1) + fibo(n-2);
}

int[] arr = new int[input];
arr[0] = 1;
arr[1] = 1;

void fibo2(int n)
{
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i-2] + arr[i-1];

        count2++;
    }
}

fibo(input);
fibo2(input);

System.Console.WriteLine(count1);
System.Console.WriteLine(count2);