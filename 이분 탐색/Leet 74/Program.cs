public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        bool isFound = false;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if(matrix[i][0] <= target && target <= matrix[i][matrix[i].Length-1])
            {
                isFound = true;

                int left = 0;
                int right = matrix[i].Length - 1;
                
                while (true)
                {
                    if(left > right)
                        return false;

                    int mid = (left + right) / 2;

                    if(target == matrix[i][mid])
                        return true;

                    else if(target > matrix[i][mid])
                        left = mid + 1;

                    else
                        right = mid - 1;
                }
            }

            if(isFound)
                return false;
        }

        return false;
    }
}