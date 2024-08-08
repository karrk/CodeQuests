namespace BOJ_11403
{
    internal class Program
    {
        // 2024 08 07
        // 문제 : 백준 11403 경로 찾기
        // url : https://www.acmicpc.net/problem/11403

        static void Main(string[] args)
        {
            int nodes = int.Parse(Console.ReadLine());

            int[][] paths = new int[nodes][];
            bool[] isChecked = new bool[nodes];

            for (int i = 0; i < nodes; i++)
            {
                paths[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }

            for (int i = 0; i < nodes; i++)
            {
                if (isChecked[i])
                    continue;

                for (int j = 0; j < nodes; j++)
                {
                    if (paths[i][j] == 1 && i != j)
                    {
                        PathUpdate(paths, isChecked, i, j);
                    }
                }
            }
        }

        static void CopyPaths(int[] m_origin, int[] m_source)
        {
            for (int i = 0; i < m_source.Length; i++)
            {
                if (m_source[i] == 1 && m_origin[i] == 0)
                    m_origin[i] = 1;

            }
        }

        static int[] PathUpdate(int[][] m_paths,bool[] m_checked, int m_start, int m_current)
        {

        }


    }
}
