public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        int[] power = new int[mat.Length];
            List<int> powerValue = new List<int>();
            int min = int.MaxValue;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] != 0)
                        sum++;
                }
                power[i] = sum;

                if (!powerValue.Contains(sum))
                {
                    powerValue.Add(sum);
                }
            }

            powerValue.Sort();

            int count = 0;

            List<int> ls = new List<int>();

            for (int i = 0; i < power.Length; i++)
            {
                for (int j = 0; j < power.Length; j++)
                {
                    if (powerValue[i] == power[j])
                    {
                        ls.Add(j);
                        count++;
                    }

                    if(count == k)
                    {
                        i = power.Length;
                        break;
                    }
                }
            }
            
            return ls.ToArray();
    }
}