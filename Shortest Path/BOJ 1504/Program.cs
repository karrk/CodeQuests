using System.Net;

string[] str = Console.ReadLine().Split(' ');

int n = int.Parse(str[0]);
int e = int.Parse(str[1]);

int[][] arr = new int[e][];

for (int i = 0; i < arr.Length; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);

    arr[i] = new int[] { a, b, c };
}

str = Console.ReadLine().Split(' ');

int[] needPoint = { int.Parse(str[0]), int.Parse(str[1]) };

int max = int.MaxValue;

Console.WriteLine(Solution2(arr, n, needPoint));

long Solution2(int[][] arr, int n, int[] needPoint)
{
    Dictionary<long, List<long[]>> nodirection = new Dictionary<long, List<long[]>>();

    for (int i = 0; i < arr.Length; i++)
    {
        int x = arr[i][0];
        int y = arr[i][1];
        int z = arr[i][2];

        if (!nodirection.ContainsKey(x))
        {
            nodirection[x] = new List<long[]>();
        }

        if (!nodirection.ContainsKey(y))
        {
            nodirection[y] = new List<long[]>();
        }

        nodirection[x].Add(new long[] { y, z });
        nodirection[y].Add(new long[] { x, z });
    }


    long a, d;
    long b, e;
    long c, f;

    long first = -1;
    long second = -1;

    a = Dijkstra(nodirection, n, 1, needPoint[0]);
    
    if(a != int.MaxValue)
    {
        b = Dijkstra(nodirection, n, needPoint[0], needPoint[1]);

        if (b != int.MaxValue)
        {
            c = Dijkstra(nodirection, n, needPoint[1], n);

            if (c != int.MaxValue)
                first = a + b + c;
        }
    }
    
    

    d = Dijkstra(nodirection, n, 1, needPoint[1]);

    if (d != int.MaxValue)
    {
        e = Dijkstra(nodirection, n, needPoint[1], needPoint[0]);

        if (e != int.MaxValue)
        {
            f = Dijkstra(nodirection, n, needPoint[0], n);

            if (f != int.MaxValue)
                second = d + e + f;
        }
    }

    if (first == -1 && second == -1)
        return -1;

    long result = first < second ? first : second;

    return result;
}

long Dijkstra(Dictionary<long, List<long[]>> graph,int vertexs, int start, int target)
{
    long[] costs = new long[vertexs];
    PriorityQueue<long[], long> pq = new PriorityQueue<long[], long>();

    for (int i = 0; i < vertexs; i++)
    {
        costs[i] = int.MaxValue;
    }

    costs[start-1] = 0;

    pq.Enqueue(new long[] { start, costs[start-1] }, costs[start-1]);

    while (true)
    {
        if (pq.Count <= 0)
            break;

        long[] node = pq.Dequeue();
        long v = node[0];
        long c = node[1];

        if (!graph.ContainsKey(v))
            continue;

        for (int i = 0; i < graph[v].Count; i++)
        {
            long nextV = graph[v][i][0];
            long cost = graph[v][i][1];

            long nextCost = c + cost;

            if (costs[nextV-1] > nextCost)
            {
                costs[nextV - 1] = nextCost;
                pq.Enqueue(new long[] { nextV, costs[nextV - 1] }, costs[nextV - 1]);
            }
        }
    }

    return costs[target - 1];
}