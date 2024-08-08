using System.Diagnostics.CodeAnalysis;

namespace BOJ_2667
{
    // 2024 08 06
    // 문제 : 백준 2667 단지번호붙이기
    // url : https://www.acmicpc.net/problem/2667

    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char[][] map = new char[input][];
            List<int> result = new List<int>();

            for (int i = 0; i < input; i++)
            {
                map[i] = Console.ReadLine().ToCharArray();
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(0); j++)
                {
                    if (map[i][j] == '1')
                    {
                        map[i][j] = '0';
                        result.Add(GetTotalCount(map, i, j, 1));
                    }
                }
            }

            result.Sort();

            Console.WriteLine(result.Count);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static int GetTotalCount(char[][] m_map,int m_posY, int m_posX, int count)
        {
            int limit = m_map.Length-1;

            // 위
            if(0 <= m_posY-1 && m_map[m_posY - 1][m_posX] == '1')
            {
                m_map[m_posY - 1][m_posX] = '0';
                count = GetTotalCount(m_map, m_posY - 1, m_posX, ++count);
            }
            // 아래
            if (limit >= m_posY + 1 && m_map[m_posY + 1][m_posX] == '1')
            {
                m_map[m_posY + 1][m_posX] = '0';
                count = GetTotalCount(m_map, m_posY + 1, m_posX, ++count);
            }
            // 좌
            if (0 <= m_posX - 1 && m_map[m_posY][m_posX-1] == '1')
            {
                m_map[m_posY][m_posX-1] = '0';
                count = GetTotalCount(m_map, m_posY, m_posX-1, ++count);
            }
            // 우
            if (limit >= m_posX + 1 && m_map[m_posY][m_posX + 1] == '1')
            {
                m_map[m_posY][m_posX + 1] = '0';
                count = GetTotalCount(m_map, m_posY, m_posX + 1, ++count);
            }

            return count;
        }
    }
}
