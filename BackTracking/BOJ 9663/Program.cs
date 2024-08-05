int n = int.Parse(Console.ReadLine());
int count = 0;

int[] board = new int[n];
Array.Fill(board,-1);

for (int i = 0; i < n; i++)
{
    DFS(i,0);
}

System.Console.WriteLine(count);

void DFS(int column,int step)
{
    for (int j = 1; j < step + 1; j++)
    {
        int critical_left = column - j; // 현재 column 일때
        int critical_right = column + j; // 나오면 안되는값

        if (board[step - j] == critical_left || 
            board[step - j] == critical_right)
            return;
    }

    if (step >= n-1)
    {
        count++;
        return;
    }

    board[step] = column;

    for (int i = 0; i < n; i++)
    {
        if(column-2 < i && i < column+2)
            continue;
        
        if(board.Contains(i))
            continue;

        DFS(i,step+1);
        board[step+1] = -1;
    }
}