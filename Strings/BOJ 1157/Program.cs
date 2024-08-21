namespace BOJ_1157
{
    // 24년 08월 21일
    // 문제 : BOJ 1157 단어 공부
    // url : https://www.acmicpc.net/problem/1157

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.Solution1();
        }
    }

    public class Solution
    {
        public void Solution1()
        {
            int[] chars = new int[26];

            string input = Console.ReadLine();
            char temp = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                temp = input[i];

                if (temp > 'Z')
                    temp -= (char)('a'-'A');

                temp -= 'A';

                chars[temp]++;
            }

            int max = chars.Max();
            int tempNum = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == max)
                {
                    tempNum += max;
                    temp = (char)(i + 'A');
                }
            }

            if(max != tempNum)
                Console.WriteLine('?');
            else
                Console.WriteLine(temp);
        }
    }
}
