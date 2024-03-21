int tCase = int.Parse(Console.ReadLine());

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int[][] dp = new int[tCase+1][];

dp[1] = new int[]{input[0],input[1],input[2]};

for (int i = 2; i < dp.GetLength(0); i++)
{
    input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
    
    dp[i] = new int[3];
    dp[i][0] = Math.Min(dp[i-1][1],dp[i-1][2]) + input[0];
    dp[i][1] = Math.Min(dp[i-1][2],dp[i-1][0]) + input[1];
    dp[i][2] = Math.Min(dp[i-1][0],dp[i-1][1]) + input[2];
}

System.Console.WriteLine(dp[dp.Length-1].Min());