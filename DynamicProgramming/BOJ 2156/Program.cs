System.Console.WriteLine(Test());

int Test()
{
    int n = int.Parse(Console.ReadLine());

    int[] arr = new int[n + 1];
    int[] dp = new int[n + 1];

    for (int i = 1; i < arr.Length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }

    dp[1] = arr[1];

    if (n == 1)
        return dp[1];

    dp[2] = arr[1] + arr[2];

    if (n == 2)
        return dp[2];

    dp[3] = Math.Max(arr[3] + arr[2] + dp[0],dp[1] + arr[3]);

    for (int i = 4; i < arr.Length; i++)
    {
        dp[i] = Math.Max(arr[i] + arr[i - 1] + dp[i - 3],
                                Math.Max(dp[i - 2] + arr[i],
                                arr[i]+arr[i-1]+dp[i-4]));
    }

    return dp.Max();
}