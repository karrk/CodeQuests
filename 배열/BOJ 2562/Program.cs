using System;
using System.Collections.Generic;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int count = 0;

            int[] arr = new int[9];

            for (int i = 0; i < arr.Length; i++)
            {
                string s = Console.ReadLine();
                arr[i] = int.Parse(s);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    count = i + 1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(count);

        }
    }
}
