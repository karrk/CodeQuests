int input = int.Parse(Console.ReadLine());

List<long> dp = new List<long>(){1,1,1};

for (int i = 0; i < input; i++)
{
    int n = int.Parse(Console.ReadLine());

    for (int j = dp.Count; j < n; j++)
    {
        dp.Add(dp[j-3] + dp[j-2]);
    }

    System.Console.WriteLine(dp[n-1]);
}