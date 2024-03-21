using System.Text;

int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
StringBuilder sb = new StringBuilder();

int vertexes = input[0];
int nodeCount = input[1];
int startNum = input[2];

int[] visited = new int[vertexes+1];
int[][] nodes = new int[vertexes+1][];

for (int i = 0; i < nodeCount; i++)
{
    input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    int a = input[0];
    int b = input[1];

    if(nodes[a] == null)
        nodes[a] = new int[vertexes+1];
    
    if(nodes[b] == null)
        nodes[b] = new int[vertexes+1];

    nodes[a][b] = 1;
    nodes[b][a] = 1;
}

DFS(nodes,visited,startNum);
Array.Fill(visited,0);
sb.AppendLine();
BFS(nodes,visited,startNum);

System.Console.WriteLine(sb);

void DFS(int[][] nodes,int[] visited, int start)
{
    sb.Append($"{start} ");

    if(nodes[start] == null || nodes[start].Sum() == 0)
        return;

    visited[start] = 1;

    for (int i = 1; i < visited.Length; i++)
    {
        if(visited[i] == 1 || nodes[start][i] == 0)
            continue;

        DFS(nodes,visited,i);
    }
}

void BFS(int[][] nodes,int[] visited, int start)
{
    Queue<int> q = new Queue<int>();

    q.Enqueue(start);
    visited[start] = 1;

    while(true)
    {
        if(q.Count <= 0)
            break;

        int info = q.Dequeue();
        sb.Append($"{info} ");

        if(nodes[info] == null)
            continue;

        for (int i = 1; i < nodes[info].Length; i++)
        {
            if(nodes[info][i] == 0 || visited[i] == 1)
                continue;

            q.Enqueue(i);
            visited[i] = 1;
        }
    }
}


