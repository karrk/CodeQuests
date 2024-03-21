using System.Text;

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int n = input[0];
int m = input[1];

DisjointSet set = new DisjointSet();
StringBuilder sb = new StringBuilder();

for (int i = 0; i <= n; i++)
{
    set.Add(i);
}

for (int i = 0; i < m; i++)
{
    input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    if(input[0] == 0)
        set.Union(input[1],input[2]);
    else
    {
        if(set.Find(input[1]) == set.Find(input[2]))
            sb.AppendLine("YES");
        else
            sb.AppendLine("NO");
    }
}

System.Console.WriteLine(sb);

class DisjointSet
{
    Dictionary<int,int> dic;

    public DisjointSet()
    {
        dic = new Dictionary<int, int>();
    }

    public void Add(int element)
    {
        if(!dic.ContainsKey(element))
            dic.Add(element,element);
    }

    public void Union(int x, int y)
    {
        if(!dic.ContainsKey(x))
            return;
        
        if(!dic.ContainsKey(y))
            return;

        x = Find(x);
        y = Find(y);

        int min = Math.Min(x,y);
        int max = Math.Max(x,y);

        dic[max] = min;
    }

    public int Find(int element)
    {
        if(!dic.ContainsKey(element))
            return int.MaxValue;

        if(dic[element] != element)
            dic[element] = Find(dic[element]);

        return dic[element];
    }
}

