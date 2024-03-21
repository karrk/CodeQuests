using System;
using System.Collections.Generic;


namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine().ToString());

            switch (num)
            {
                case int n when (n >= 90):
                Console.WriteLine("A");
                    break;
                case int n when (n >= 80):
                    Console.WriteLine("B");
                    break;
                case int n when (n >= 70):
                    Console.WriteLine("C");
                    break;
                case int n when (n >= 60):
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
    }
}
