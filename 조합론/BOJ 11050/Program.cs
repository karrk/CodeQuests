string[] input = Console.ReadLine().Split(' ');

int n = int.Parse(input[0]);
int k = int.Parse(input[1]);

int[][] dp = new int[n + 1][];
dp[0] = new int[] { 1 };

System.Console.WriteLine(Test(n,k));

int Test(int n, int k)
{
    for (int i = 1; i < dp.Length; i++)
    {
        dp[i] = new int[dp[i - 1].Length + 1];

        dp[i][0] = 1;
        dp[i][dp[i].Length - 1] = 1;

        for (int j = 1; j < dp[i].Length - 1; j++)
        {
            dp[i][j] = dp[i - 1][j - 1] + dp[i - 1][j];
        }
    }
    return dp[n][k];
}