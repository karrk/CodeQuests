int num = int.Parse(Console.ReadLine());

int[] dp = Enumerable.Repeat(int.MaxValue-1,num+1).ToArray();

dp[1] = 0;

for (int i = 2; i < dp.Length; i++)
{
    int devide2 = i % 2 == 0 ? dp[i/2] : int.MaxValue -1;
    int devide3 = i % 3 == 0 ? dp[i/3] : int.MaxValue -1;

    dp[i] = Math.Min(dp[i-1]+1,Math.Min(devide2+1,devide3+1));
}

System.Console.WriteLine(dp[num]);