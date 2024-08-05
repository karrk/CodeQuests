using System.Numerics;

Solution1 s = new Solution1();

    s.Solution();


public class Solution1
{
    public void Solution()
    {
        string[] input = Console.ReadLine().Split(' ');
        Vector2 a = new Vector2(long.Parse(input[0]), long.Parse(input[1]));
        Vector2 b = new Vector2(long.Parse(input[2]), long.Parse(input[3]));

        input = Console.ReadLine().Split(' ');
        Vector2 c = new Vector2(long.Parse(input[0]), long.Parse(input[1]));
        Vector2 d = new Vector2(long.Parse(input[2]), long.Parse(input[3]));

        //abc abd : cda cdb 를 비교

        long abc = (long)((b.X - a.X) * (c.Y - a.Y) - (c.X - a.X) * (b.Y - a.Y));
        long abd = (long)((b.X - a.X) * (d.Y - a.Y) - (d.X - a.X) * (b.Y - a.Y));

        long cda = (long)((d.X - c.X) * (a.Y - c.Y) - (a.X - c.X) * (d.Y - c.Y));
        long cdb = (long)((d.X - c.X) * (b.Y - c.Y) - (b.X - c.X) * (d.Y - c.Y));

        if ( abc > 0 ) 
        {
            abc = 1;
        }
        else if ( abc < 0 ) {
            abc = -1;
        }

        if ( abd > 0 ) 
        {
            abd = 1;
        }
        else if ( abd < 0 ) {
            abd = -1;
        }

        if ( cda > 0 ) 
        {
            cda = 1;
        }
        else if ( cda < 0 ) {
            cda = -1;
        }

        if ( cdb > 0 ) 
        {
            cdb = 1;
        }
        else if ( cdb < 0 ) {
            cdb = -1;
        }

        if ( abc == 0 && abd == 0 && cda == 0 && cdb == 0 )
        {
            if ( Math.Min(a.X, b.X) <= Math.Max(c.X,d.X)
            && Math.Min(c.X, d.X) <= Math.Max(a.X,b.X)
            && Math.Min(a.Y, b.Y) <= Math.Max(c.Y,d.Y)
            && Math.Min(c.Y, d.Y) <= Math.Max(a.Y,b.Y) )
            {
                System.Console.WriteLine(1);
            }
            else
            {
                System.Console.WriteLine(0);
            }
            return;
   
        }
        else if (abc * abd <= 0) // 각자 다른방향을 향하는지 확인
        {
            if (cda * cdb <= 0)
            {
                System.Console.WriteLine(1);
                return;
            }
        }

        System.Console.WriteLine(0);
    }
}

public class Solution2
{
    public void Solution()
    {
        int total = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');

        int[] basicArr = new int[input.Length];
        int[] removeArr = new int[input.Length];

        basicArr[0] = int.Parse(input[0]);
        removeArr[0] = basicArr[0];

        for (int i = 1; i < input.Length; i++)
        {
            int value = int.Parse(input[i]);
        }
    }
}