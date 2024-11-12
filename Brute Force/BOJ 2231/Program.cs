namespace BOJ_2231
{
    // 24/11/12
    // BOJ 2231
    // URL : https://www.acmicpc.net/problem/2231

    internal class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int standard = 1000000;
            int divisor;
            int leftValue;
            int currentValue;
            int sum = 0;
            int min = int.MaxValue;

            for (int i = target; i >= 0; i--)
            {
                if (standard > target) { standard /= 10; i++; continue; }
                divisor = standard;
                currentValue = i;

                sum = i;

                while (true)
                {
                    if (divisor <= 0)
                        break;

                    leftValue = currentValue / divisor;
                    sum += leftValue;
                    currentValue %= divisor;
                    divisor /= 10;
                }

                if (sum == target && i < min)
                { min = i; }
            }

            Console.WriteLine(min == int.MaxValue ? 0 : min);
        }
    }
}
