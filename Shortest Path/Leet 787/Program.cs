using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;

public class Solution {
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k) {
        Dictionary<int, List<int[]>> nodes = new Dictionary<int, List<int[]>>();

        k++;
        int[,] costs = new int[n,2];

        for (int i = 0; i < n; i++)
        {
            costs[i,0] = int.MaxValue;
            costs[i, 1] = int.MaxValue;
        }

        costs[src,0] = 0;

        for (int i = 0; i < flights.Length; i++)
        {
            int x = flights[i][0];
            int y = flights[i][1];
            int z = flights[i][2];

            if (!nodes.ContainsKey(x))
                nodes.Add(x, new List<int[]>());

            nodes[x].Add(new int[] { y, z });
        }

        // k 가 0 로 입력받으면 k는 1로 정점을 한번 찍을수 있게 한다.
        // k 가 0 이되면 갈곳이 없다.

        PriorityQueue<int[], int> pq = new PriorityQueue<int[], int>();
        
        pq.Enqueue(new int[] { src, 0, k }, 0);

        while (true)
        {
            if (pq.Count <= 0)
                break;

            int[] node = pq.Dequeue();
            int v = node[0];
            int c = node[1];
            int trans = node[2];

            if(v == dst)
            {
                Console.WriteLine(c);
                return c;
            }

            if (v != src)
                trans--;

            if (!nodes.ContainsKey(v))
                continue;

            if (trans <= 0)
                continue;

            foreach (var next in nodes[v])
            {
                int next_v = next[0];
                int cost = next[1];

                if (costs[next_v,0] > cost + c)
                {
                    costs[next_v, 0] = cost + c;
                    costs[next_v, 1] = trans;
                    pq.Enqueue(new int[] { next_v, costs[next_v, 0],trans }, costs[next_v, 0]);
                }
                else if (costs[next_v,1] < trans)
                {
                    pq.Enqueue(new int[] { next_v, cost + c , trans }, cost + c);
                }
            }
        }

        int result = costs[dst,0];

        if (result == int.MaxValue || result == 0)
            return -1;
        else
            return result;
    }
}