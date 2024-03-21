Dictionary<(int,int,int),int> dic = new Dictionary<(int, int, int), int>();

int Func(int a, int b, int c)
{
    if(dic.ContainsKey((a,b,c)))
        return dic[(a,b,c)];

    if(a <= 0 || b <= 0 || c <= 0)
    {
        dic.Add((a,b,c),1);
        return 1;
    }
    
    if(a > 20 || b > 20 || c > 20)
    {
        dic.Add((a,b,c),20);
        return Func(20,20,20);
    }

    if(a < b && b < c)
    {
        dic.Add((a,b,c),Func(a,b,c-1) + Func(a,b-1,c-1) - Func(a,b-1,c));
        return Func(a,b,c-1) + Func(a,b-1,c-1) - Func(a,b-1,c);
    }

    dic.Add((a,b,c),Func(a-1,b,c) + Func(a-1,b-1,c) 
        + Func(a-1,b,c-1) - Func(a-1,b-1,c-1));

    return
        Func(a-1,b,c) + Func(a-1,b-1,c) 
        + Func(a-1,b,c-1) - Func(a-1,b-1,c-1);
}

while (true)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    if(input[0] == -1 && input[1] == -1 && input[2] == -1)
        break;

    System.Console.WriteLine($"w({input[0]}, {input[1]}, {input[2]}) = {Func(input[0],input[1],input[2])}");
}
