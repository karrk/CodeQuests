Solution2.Solution();

public class Solution2
{
    static int Max = 30;
    static int[][] dp;

    public static void Solution()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            dp = new int[m+1][];

            for (int j = 0; j < dp.GetLength(0); j++)
            {
                dp[j] = new int[n+1];
            }

            
            System.Console.WriteLine(Test(n,m));
        }
    }

    static int Test(int n, int m)
    {
        if(dp[m][n] != 0)
            return dp[m][n];

        if(n == 1)
            return m;

        if(n == m)
            return 1;

        return dp[m][n] = Test(n-1,m-1) + Test(n,m-1);
    }
}