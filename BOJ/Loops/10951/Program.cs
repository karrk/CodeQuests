using System;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (s == null) break;

                string[] sum = s.Split();
                Console.WriteLine((int.Parse(sum[0]) + int.Parse(sum[1])));

            }
        }
    }
}
