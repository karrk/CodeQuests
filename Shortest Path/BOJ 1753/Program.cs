using System.Collections.Generic;
using System.Text;

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
int start = int.Parse(Console.ReadLine());

int vertexes = input[0];
int edges = input[1];

PriorityQueue<(int,int),int> pq = new PriorityQueue<(int,int),int>();

Dictionary<int,List<(int,int)>> nodesInfo = new Dictionary<int, List<(int, int)>>();

int[] costs = new int[vertexes+1];
int[] visited = new int[vertexes+1];

Array.Fill(costs,int.MaxValue);
costs[start] = 0;

for (int i = 0; i < edges; i++)
{
    input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    if(!nodesInfo.ContainsKey(input[0]))
        nodesInfo.Add(input[0],new List<(int,int)>());

    nodesInfo[input[0]].Add((input[1],input[2]));
}

pq.Enqueue((start,0),0);

while (true)
{
    if(pq.Count <= 0)
        break;

    (int,int) temp = pq.Dequeue();
    int cur_v = temp.Item1;
    int cur_cost = temp.Item2;

    if(visited[cur_v] == 1)
        continue;

    visited[cur_v] = 1;

    if(!nodesInfo.ContainsKey(cur_v))
        continue;

    for (int i = 0; i < nodesInfo[cur_v].Count; i++)
    {
        (int,int) edge = nodesInfo[cur_v][i];

        int next = edge.Item1;
        int edgeCost = edge.Item2;

        if(cur_cost + edgeCost < costs[next])
        {
            costs[next] = cur_cost + edgeCost;

            if(visited[next] == 0)
                pq.Enqueue((next,costs[next]),costs[next]);
        }
    }
}

StringBuilder sb = new StringBuilder();

for (int i = 1; i <= vertexes; i++)
{
    if(costs[i] != int.MaxValue)
        sb.AppendLine($"{costs[i]}");
    else
        sb.AppendLine("INF");
}

System.Console.WriteLine(sb);