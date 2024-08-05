using System;
using System.Collections.Generic;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            List<string> s = new List<string>();

            while (s.Count != input)
            {
                string[] input2 = Console.ReadLine().Split();

                for (int i = 0; i < input2.Length; i++)
                {
                    s.Add(input2[i]);
                }
            }

            int min = int.Parse(s[0]);
            int max = int.Parse(s[0]);

            for (int i = 0; i < s.Count; i++)
            {
                if (int.Parse(s[i]) < min)
                    min = int.Parse(s[i]);

                if (int.Parse(s[i]) > max)
                    max = int.Parse(s[i]);
            }

            Console.WriteLine($"{min} {max}");

        }
    }
}
