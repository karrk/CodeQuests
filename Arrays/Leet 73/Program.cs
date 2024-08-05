public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> zeroLine = new HashSet<int>();

        for (int i = 0; i < matrix[0].Length; i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                if(matrix[j][i] == 0)
                {
                    for (int k = 0; k < matrix.GetLength(0); k++)
                    {
                        if(matrix[k][i] == 0)
                        {
                            zeroLine.Add(k);
                            continue;
                        }

                        matrix[k][i] = 0;
                    }

                    zeroLine.Add(j);
                    break;
                }
            }
        }

        foreach (var i in zeroLine)
        {
            Array.Fill(matrix[i],0);
        }
    }
}