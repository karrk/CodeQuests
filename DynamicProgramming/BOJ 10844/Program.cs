int n = int.Parse(Console.ReadLine());

long[][] dp = new long[n][];

dp[0] = new long[10];
Array.Fill(dp[0],1);
dp[0][0] = 0;

for (int i = 1; i < dp.GetLongLength(0); i++)
{
    dp[i] = new long[10];

    dp[i][0] = dp[i-1][1] % 1000000000;
    dp[i][9] = dp[i-1][8] % 1000000000;

    for (int j = 1; j < 9; j++)
    {
        dp[i][j] = dp[i-1][j+1] + dp[i-1][j-1] % 1000000000;
    }
}

System.Console.WriteLine(dp[n-1].Sum() % 1000000000);