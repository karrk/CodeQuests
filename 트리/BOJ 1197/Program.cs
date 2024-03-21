int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int v = input[0];
int e = input[1];

DisjointSet set = new DisjointSet();
PriorityQueue<(int,int,long),long> pq = new PriorityQueue<(int,int, long), long>();

for (int i = 1; i <= v; i++)
{
    set.Add(i);
}

for (int i = 0; i < e; i++)
{
    input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    pq.Enqueue((input[0],input[1],input[2]),input[2]);
}

long sum = 0;
int step = 0;

while (true)
{
    if(pq.Count <= 0 || step > v-1)
        break;

    (int,int,long) temp = pq.Dequeue();

    int node = temp.Item1;
    int target = temp.Item2;
    long cost = temp.Item3;

    if(set.Find(node) == set.Find(target))
        continue;

    set.Union(node,target);
    sum += cost;
    step++;
}

System.Console.WriteLine(sum);

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

