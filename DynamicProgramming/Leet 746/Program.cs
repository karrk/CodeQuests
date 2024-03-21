public class Solution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        for (int i = 2; i < cost.Length; i++)
        {
            int mincost = cost[i-2] < cost[i-1] ? cost[i-2] : cost[i-1];
            cost[i] += mincost;
        }
        
        return cost[cost.Length-2] < cost[cost.Length-1] ? 
                cost[cost.Length-2] : cost[cost.Length-1];
    }
}