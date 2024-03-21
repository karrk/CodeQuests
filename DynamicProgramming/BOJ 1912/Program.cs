int[] dp = new int[int.Parse(Console.ReadLine())];
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

dp[0] = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    dp[i] = Math.Max(dp[i-1] + arr[i], arr[i]);
}

System.Console.WriteLine(dp.Max());