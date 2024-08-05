using System;

namespace Baekjoon
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            Console.WriteLine(double.Parse(inputs[0])/ double.Parse(inputs[1]));
        }

    }
}