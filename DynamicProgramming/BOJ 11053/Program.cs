int n = int.Parse(Console.ReadLine());

int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
int[] dp = new int[arr.Length];

dp[0] = 1;

for (int i = 1; i < arr.Length; i++)
{
    for (int j = 0; j < i; j++)
    {
        if(arr[j] < arr[i])
            dp[i] = Math.Max(dp[i] , dp[j]+1);
    }

    if(dp[i] == 0)
        dp[i] = 1;
}

System.Console.WriteLine(dp.Max());