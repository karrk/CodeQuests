namespace BOJ_5622
{
    // 24 08 26
    // 문제 : BOJ 5622 다이얼
    // url : https://www.acmicpc.net/problem/5622

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> table = new Dictionary<char, int>();

            int ch;
            int count;
            int start = 3;
            int result = 0;

            for (int i = 0; i < 25; i++)
            {
                ch = 'A' + i;

                if (ch == 'P' || ch == 'W')
                    count = 4;
                else
                    count = 3;

                for (int j = 0; j < count; j++)
                {
                    table.Add((char)(ch + j), start);
                }

                start++;
                i += count - 1;
            }

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                result += table[input[i]];
            }

            Console.WriteLine(result);
        }
    }
}
