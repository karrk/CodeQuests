using System.Text;

int input = int.Parse(Console.ReadLine());

int[,] arr = new int[input+1,input+1];
StringBuilder sb = new StringBuilder();

Fill(1,input+1,1,input+1);

for (int i = 1; i < arr.GetLength(0); i++)
{
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        if(arr[i,j] == 1)
            sb.Append('*');
        else
            sb.Append(' ');
    }
    sb.AppendLine();
}

System.Console.WriteLine(sb);

void Fill(int sx, int ex, int sy, int ey)
{
    if((ex-sx) * (ey-sy) <= 1)
    {
        arr[sy,sx] = 1;
        return;
    }
        
    int point_1 = ((ex-sx)/3); // f(9) = 4 , f(27) = 10
    int point_2 = (((ex-sx)/3)*2); // f(9) = 7 , f(27) = 19
    int point_L = ex-sx; // f(9) = 10

    Fill(sx , sx + point_1 , sy , sy + point_1); 
    Fill(sx + point_1 , sx + point_2 , sy , sy + point_1);
    Fill(sx + point_2 , sx + point_L , sy , sy + point_1); 

    Fill(sx,sx+point_1,sy+point_1,sy+point_2);
    Fill(sx+point_2,sx+point_L,sy+point_1,sy+point_2);

    Fill(sx,sx+point_1,sy+point_2,sy+point_L);
    Fill(sx+point_1,sx+point_2,sy+point_2,sy+point_L);
    Fill(sx+point_2,sx+point_L,sy+point_2,sy+point_L);
}