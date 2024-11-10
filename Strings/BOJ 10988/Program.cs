namespace BOJ_10988
{
    // 24 08 06
    // 문제 : BOJ 10988 팰린드롬인지 확인하기
    // url : https://www.acmicpc.net/problem/10988

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] != input[input.Length-1-i])
                {
                    Console.WriteLine(0);
                    return;
                }
            }

            Console.WriteLine(1);
        }
    }
}
