namespace BOJ_2798
{
    // 24/11/09
    // 문제 : BOJ 2789
    // URL : https://www.acmicpc.net/problem/2798

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] cards = new int[input[0]];
            int target = input[1];

            input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int i = 0; i < input.Length; i++)
            {
                cards[i] = input[i];
            }

            int sum = 0;

            sum = Find(cards, 0, 0, 0,target);

            Console.WriteLine(sum);
        }

        static int Find(int[] cards, int idx, int selectCount, int currentSum, int target)
        {
            if (selectCount == 3)
            {
                return currentSum <= target ? currentSum : -1;
            }

            int maxSum = -1;

            for (int i = idx; i < cards.Length; i++)
            {
                int result = Find(cards, i + 1, selectCount + 1, currentSum + cards[i], target);
                
                if (result != -1)
                {
                    maxSum = Math.Max(maxSum, result);
                }
            }

            return maxSum;
        }

    }
}
