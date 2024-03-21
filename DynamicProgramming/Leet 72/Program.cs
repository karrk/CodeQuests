public class Solution {
    public int MinDistance(string word1, string word2)
    {
        int[][] dp = new int[word2.Length+1][];

        for (int i = 0; i < dp.GetLength(0); i++)
        {
            dp[i] = new int[word1.Length+1];
            dp[i][0] = i;
        }

        for (int i = 1; i < dp[0].Length; i++)
        {
            dp[0][i] = i;
        }



        for (int i = 1; i < dp.GetLength(0); i++)
        {
            for (int j = 1; j < dp[0].Length; j++)
            {
                if(word2[i-1] == word1[j-1])
                    dp[i][j] = dp[i-1][j-1];
                else
                {
                    int insert = dp[i-1][j] + 1;

                    int delete = dp[i][j-1] + 1;

                    int replace = dp[i-1][j-1] + 1;

                    dp[i][j] = Math.Min(Math.Min(insert,delete),replace);
                }
            }
        }

        return dp[dp.GetLength(0)-1][dp[0].Length-1];

    }
}