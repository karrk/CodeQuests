namespace BOJ_2747
{
    internal class Program
    {
        // 24 08 22
        // 문제 : BOJ 2747 피보나치 수
        // url : https://www.acmicpc.net/problem/2747

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n+1];

            arr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            Console.WriteLine(arr[n]);
        }
    }
}
