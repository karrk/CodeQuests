public class Solution {

    int vertexs;
    int[] costs;

    public int MinCostConnectPoints(int[][] points) {
        vertexs = points.Length;

            bool[] visited = new bool[vertexs];
            costs = new int[vertexs];

            for (int i = 0; i < vertexs; i++)
            {
                visited[i] = false;
                costs[i] = int.MaxValue;
            }

            int[] currentV = points[0];

            costs[0] = 0;
            visited[0] = true;

            for (int i = 0; i < vertexs -1; i++)
            {
                int next = MinCostIdx(currentV,points,visited);

                visited[next] = true;

                currentV = points[next];
            }

            int sum = 0;

            foreach (var cost in costs)
            {
                sum += cost;
            }

            return sum;
    }

    int MinCostIdx(int[] current,int[][] vertexs,bool[] visited)
        {
            int minCost = int.MaxValue;
            int min_Idx = -1;

            for (int i = 0; i < vertexs.Length; i++)
            {
                int x = Math.Abs((current[0]) - (vertexs[i][0]));
                int y = Math.Abs((current[1]) - (vertexs[i][1]));

                int cost = x + y;

                if(!visited[i] &&costs[i] > cost)
                {
                    costs[i] = cost;
                }
            }

            for (int i = 0; i < costs.Length; i++)
            {
                if(!visited[i] && minCost > costs[i])
                {
                    minCost = costs[i];
                    min_Idx = i;
                }
            }

            return min_Idx;
        }
}