public class Solution {
    int[] dp;

    public int[] CountBits(int n)
    {
        if(n == 0)
           return new int[]{0};

        dp = new int[n+1];

        dp[0] = 0;

        for ( int i = 0; i <= n; i++ )
        {
            dp[i] = dp[i/2] + (i%2);
        }

        return dp;
        /*

        int nextIdx = 1;
        int prevCount = 1;
        int nextCount = 1;

        while (true)
        {   
            for (int i = 0; i < nextCount; i++)
            {
                dp[nextIdx] = dp[i]+1;

                if(nextIdx == n)
                    return dp;

                nextIdx++;
                prevCount++;
            }
            nextCount = prevCount;
        }
        */

    }
}