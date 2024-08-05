using System.Text;

namespace BOJ_1181
{
    // 2024 08 05
    // 문제 : 백준 1181 단어 정렬
    // url : https://www.acmicpc.net/problem/1181

    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] strs = new string[count];

            for (int i = 0; i < count; i++)
            {
                strs[i] = Console.ReadLine();
            }

            // 소문자로만 구성되는 제약조건이 있음
            // 아스키 코드를 활용한다.
            // a - 97 ... z - 122

            Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

            int start = 0;
            int end = 0;
            int length = strs[0].Length;

            while (true)
            {
                if (end == strs.Length)
                    break;

                for (int i = start+1; i < strs.Length; i++)
                {
                    if (length < strs[i].Length)
                        break;

                    end++;
                }

                if(start == end)
                {
                    start++;
                    end++;
                    length = strs[start].Length;
                }
                else
                {
                    for (int i = start; i < end; i++)
                    {
                        string word1 = strs[i];
                        string word2 = strs[i + 1];

                        for (int j = 0; j < word1.Length; j++)
                        {
                            if (word1[j] > word2[j])
                            {
                                string temp = strs[i];
                                strs[i] = strs[i + 1];
                                strs[i + 1] = temp;

                                break;
                            }
                            else if (word1[j] < word2[j])
                                break;
                        }
                    }


                    start = end + 1;
                    end++;
                    length = strs[start].Length;
                }
            }

            Console.WriteLine();
        }
    }
}
