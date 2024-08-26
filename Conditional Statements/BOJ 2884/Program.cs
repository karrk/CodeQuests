namespace BOJ_2884
{
    internal class Program
    {
        // 24 08 26
        // 문제 : BOJ 2884 알람 시계
        // url : https://www.acmicpc.net/problem/2884

        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            input[1] -= 45;

            if (input[1] < 0)
            {
                input[1] += 60;
                input[0] -= 1;
            }

            if (input[0] < 0)
            {
                input[0] += 24;
            }

            Console.WriteLine($"{input[0]} {input[1]}");
        }
    }
}
