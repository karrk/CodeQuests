namespace BOJ_10872
{
    // 24년 08월 21일
    // 문제 : BOJ 10872 팩토리얼
    // url : https://www.acmicpc.net/problem/10872

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution();
        }

        static void Solution()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Recursion(input));
        }

        static int Recursion(int n)
        {
            if (n == 0)
                return 1;

            return n * Recursion(n - 1);
        }
    }
}
