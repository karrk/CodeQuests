int kg = int.Parse(Console.ReadLine());

int[] dp = Enumerable.Repeat(int.MaxValue,kg+1).ToArray();

dp[0] = 0;
dp[3] = 1;

for (int i = 5; i < dp.Length; i++)
{
    dp[i] = Math.Min(dp[i-3],dp[i-5]) + 1;

    if(dp[i] == int.MinValue)
        dp[i] = int.MaxValue;
}

if(dp[kg] == int.MaxValue)
    System.Console.WriteLine(-1);
else
    System.Console.WriteLine(dp[kg]);