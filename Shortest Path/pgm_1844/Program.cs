using System.Collections;

namespace pgm_1844
{
    // 2024 08 11
    // 문제 : 프로그래머스 1844 게임 맵 최단거리
    // url : https://school.programmers.co.kr/learn/courses/30/lessons/1844

    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 =
            {
                {1,0,1,1,1 },
                {1,0,1,0,1 },
                {1,0,1,1,1 },
                {1,1,1,0,1 },
                {0,0,0,0,1 },
            };

            int[,] arr2 =
            {
                {1,0,1,1,1 },
                {0,0,1,0,1 },
                {1,0,1,1,1 },
                {1,1,1,0,1 },
                {0,0,0,0,1 },
            };

            Solution s = new Solution();
            Console.WriteLine(s.solution(arr1)); ;
        }
    }

    class Solution
    {
        public int solution(int[,] maps)
        {
            int rows = maps.GetLength(0);
            int cols = maps.GetLength(1);
            int[] dy = { -1, 1, 0, 0 }; // 상, 하, 좌, 우
            int[] dx = { 0, 0, -1, 1 };

            bool[,] visited = new bool[rows, cols];
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(new int[] { 0, 0, 1 }); // {y, x, 현재까지 거리}
            visited[0, 0] = true;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                int y = node[0];
                int x = node[1];
                int dist = node[2];

                if (y == rows - 1 && x == cols - 1)
                {
                    return dist; // 목표 지점에 도달하면 거리 반환
                }

                for (int i = 0; i < 4; i++)
                {
                    int ny = y + dy[i];
                    int nx = x + dx[i];

                    if (ny >= 0 && ny < rows && nx >= 0 && nx < cols && maps[ny, nx] == 1 && !visited[ny, nx])
                    {
                        visited[ny, nx] = true;
                        queue.Enqueue(new int[] { ny, nx, dist + 1 });
                    }
                }
            }

            return -1; // 목표 지점에 도달할 수 없는 경우
        }
    }
}
