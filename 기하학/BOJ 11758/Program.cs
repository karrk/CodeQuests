using System.Numerics;

Solution2 s = new Solution2();
s.solution();

public class Solution2
{
    public void solution()
    {
        string[] input = Console.ReadLine().Split(' ');
        int startX = int.Parse(input[0]);
        int startY = int.Parse(input[1]);

        Vector2[] vectors = new Vector2[2];

        for (int i = 0; i < 2; i++)
        {
            input = Console.ReadLine().Split(' ');

            int x = int.Parse(input[0])-startX;
            int y = int.Parse(input[1])-startY;

            vectors[i] = new Vector2(x,y);
        }

        float cross = (vectors[0].X * vectors[1].Y) - (vectors[1].X*vectors[0].Y);

        if(cross == 0)
            System.Console.WriteLine(0);
        else if(cross > 0)
            System.Console.WriteLine(1);
        else
            System.Console.WriteLine(-1);
    }
}