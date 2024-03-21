public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        int[] parent = new int[n];

        for (int i = 0; i < parent.Length; i++)
        {
            parent[i] = i;
        }

        for (int i = 0; i < edges.Length; i++)
        {
            int v = edges[i][0];
            int t = edges[i][1];

            Union(parent, v, t);
        }

        return Find(parent,parent[source]) == Find(parent, parent[destination]);
    }

    int Find(int[] parent, int vertex)
    {
        if (parent[vertex] == vertex)
            return vertex;

        return Find(parent, parent[vertex]);
    }

    void Union(int[] parent, int a, int b)
    {
        a = Find(parent, a);
        b = Find(parent, b);

        a = Find(parent, a);
        b = Find(parent, b);

        if (a < b)
        {
            parent[b] = a;
        }
        else 
        {
            parent[a] = b; 
        }
    }
}