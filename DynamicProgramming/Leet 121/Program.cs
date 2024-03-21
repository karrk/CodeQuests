public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if(minPrice > prices[i])
            {
                minPrice = prices[i];
            }
            else if(profit < prices[i] - minPrice)
                profit = prices[i] - minPrice;
        }

        return profit;
    }
}