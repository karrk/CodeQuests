using System;

namespace Baekjoon
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(inputs[0])+ int.Parse(inputs[1]));
            Console.WriteLine(int.Parse(inputs[0])- int.Parse(inputs[1]));
            Console.WriteLine(int.Parse(inputs[0])* int.Parse(inputs[1]));
            Console.WriteLine(int.Parse(inputs[0])/ int.Parse(inputs[1]));
            Console.WriteLine(int.Parse(inputs[0])% int.Parse(inputs[1]));
        }

    }
}