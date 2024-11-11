// 24년 11월 10일
// 백준 2941
// url : https://www.acmicpc.net/problem/2941

internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, char[]> table = new Dictionary<char, char[]>
        {
            {'c',new char[]{'=','-'} },
            {'d',new char[]{'z','-'} },
            {'l',new char[]{'j'} },
            {'n',new char[]{'j'} },
            {'s',new char[]{'='} },
            {'z',new char[]{'='} },
        };

        string input = Console.ReadLine();
        char first;
        char sec;
        int count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            first = input[i-1];

            if (table.ContainsKey(first))
            {
                sec = input[i];

                if (table[first].Contains(sec))
                {
                    if(first == 'd' && sec == 'z' 
                        && (i + 1 >= input.Length || input[i + 1] != '='))
                    {
                        count += 1;
                    }

                    continue;
                }
            }

            count++;
        }

        Console.WriteLine(count);
    }
}