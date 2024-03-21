using System;
using System.Collections.Generic;

namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] s = { 1, 1, 2, 2, 2, 8 };
            for (int i = 0; i < input.Length; i++)
            {
                s[i] -= int.Parse(input[i]);
            }

            foreach (int item in s)
            {
                Console.Write(item.ToString()+" ");
            }
        }

    }
}
