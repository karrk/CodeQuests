public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<(int,int),int[]> data = new Dictionary<(int,int),int[]>();
        
        #region init
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if(i == 0 || j == 0)
                    data.Add((i,j),new int[10]);

                else if(i < 4 && j < 4)
                    data.Add((i,j),new int[10]);
            }
        }
        #endregion

        for (int i = 0; i < board.GetLength(0); i++)
        {
            char[] tempArr = board[i];

            for (int j = 0; j < tempArr.Length; j++)
            {
                if(tempArr[j] == '.')
                    continue;

                int value = tempArr[j] - '0';

                if(data[(i+1,0)][value] != 0)
                    return false;

                data[(i+1,0)][value] = value;


                if(data[(0,j+1)][value] != 0)
                    return false;

                data[(0,j+1)][value] = value;


                if(data[((i/3)+1,(j/3)+1)][value] != 0)
                    return false;

                data[((i/3)+1,(j/3)+1)][value] = value;
            }
        }

        return true;
        
    }
}