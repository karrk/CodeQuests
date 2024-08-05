namespace BOJ_25305
{
    internal class Program
    {
        // 2024년 8월 5일
        // 문제 : 백준 25305 커트라인
        // URL : https://www.acmicpc.net/problem/25305

        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] datas = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(datas,(x,y)=>y.CompareTo(x));

            Console.WriteLine(datas[input[1]-1]);
        }
    }
}
