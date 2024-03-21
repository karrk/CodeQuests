using System;
using System.Collections.Generic;

namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int a = Convert.ToInt32(input[0].ToString());
            int b = Convert.ToInt32(input[1].ToString());
            int c = Convert.ToInt32(input[2].ToString());

            Console.WriteLine((a + b) % c);
            Console.WriteLine(((a % c) + (b % c)) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine(((a % c) * (b % c)) % c);
        }
    }
}
