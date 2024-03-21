public class Solution {
    int[] costs;
    bool[] visited;

    public int NetworkDelayTime(int[][] times, int n, int start) {
        costs = new int[n];
            visited = new bool[n];
            PriorityQueue<int[],int> queue = new PriorityQueue<int[],int>();

            for (int i = 0; i < n; i++)
            {
                costs[i] = int.MaxValue;
                visited[i] = false;
            }

            costs[start - 1] = 0;
            visited[start - 1] = true;

            for (int i = 0; i < times.Length; i++)
            {
                int vertex = times[i][0];
                int target = times[i][1];
                int cost = times[i][2];

                if(vertex == start)
                {
                    if (costs[target-1] > cost)
                    {
                        costs[target-1] = cost;
                        queue.Enqueue(new int[] { target, costs[target - 1] }, costs[target - 1]);
                    }
                }
            }

            while (true)
            {
                if (queue.Count <= 0)
                    break;

                int[] node = queue.Dequeue();
                int v = node[0];
                int currentCost = node[1];

                visited[v - 1] = true;

                for (int i = 0; i < times.Length; i++)
                {
                    int vertex = times[i][0];
                    int target = times[i][1];
                    int cost = times[i][2];

                    if (vertex == v)
                    {
                        if (costs[target-1] > cost + currentCost && !visited[target-1])
                        {
                            costs[target - 1] = cost + currentCost;
                            queue.Enqueue(new int[] { target, costs[target - 1] }, costs[target - 1]);
                        }
                    }
                }
            }

            foreach (var v in visited)
            {
                if (!v)
                    return -1;
            }

            int result = 0;

            foreach (var cost in costs)
            {
                if (result < cost)
                    result = cost;
            }

            return result;
    }
}