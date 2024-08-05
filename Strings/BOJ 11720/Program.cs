using System;
using System.Collections.Generic;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string input2 = Console.ReadLine();

            int result = 0;

            if(input == input2.Length)
            {
                for (int i = 0; i < input; i++)
                {
                    result += int.Parse(input2.Substring(i, 1));
                }
            }

            Console.WriteLine(result);
        }
    }
}
