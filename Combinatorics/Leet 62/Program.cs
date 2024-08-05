public class Solution {
    public int UniquePaths(int m, int n)
    {
        int[] arr = new int[n];

        Array.Fill(arr,1);

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                arr[j] += arr[j-1];       
            }
        }

        return arr[arr.Length-1];
    }
}