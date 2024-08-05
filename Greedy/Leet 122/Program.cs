public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int[] dp = new int[prices.Length];

        dp[0] = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if(prices[i] - prices[i-1] > 0)
                dp[i] += dp[i-1] + (prices[i] - prices[i-1]);
            else
                dp[i] = dp[i-1];
        }

        return dp[dp.Length-1];
    }
}