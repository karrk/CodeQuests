int n = int.Parse(Console.ReadLine());

long[][] dp = new long[n][];

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    dp[i] = new long[input.Length];

    for (int j = 0; j < input.Length; j++)
    {
        dp[i][j] = input[j];
    }
}

for (int i = 1; i < n; i++)
{
    for (int j = 0; j < dp[i].Length; j++)
    {
        dp[i][j] += 
        Math.Max (j-1 < 0 ? 0 : dp[i-1][j-1] , 
        j >= dp[i-1].Length ? 0 : dp[i-1][j]);
    }
}

System.Console.WriteLine(dp[n-1].Max());