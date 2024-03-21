int tCase = int.Parse(Console.ReadLine());

int[] dp = Enumerable.Repeat(int.MaxValue,tCase+1).ToArray();
int[] costs = new int[tCase+1];

for (int i = 1; i <= tCase; i++)
    costs[i] = int.Parse(Console.ReadLine());

if(tCase < 3)
{
    System.Console.WriteLine(costs.Sum());
    return;
}

dp[0] = 0;
dp[1] = costs[1];
dp[2] = costs[2] + costs[1];


for (int i = 3; i < dp.Length; i++)
{
    dp[i] = Math.Max(dp[i-2],costs[i-1]+dp[i-3]) + costs[i];
}

System.Console.WriteLine(dp[dp.Length-1]);
