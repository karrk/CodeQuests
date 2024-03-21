using System;
using System.Collections.Generic;


namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input1 = Convert.ToInt32(Console.ReadLine().ToString());
            int input2 = Convert.ToInt32(Console.ReadLine().ToString());

            if (input1 > 0)
            {
                if (input2 > 0) Console.WriteLine("1");
                else Console.WriteLine("4");
            }
            else
            {
                if (input2 > 0) Console.WriteLine("2");
                else Console.WriteLine("3");
            }
        }
    }
}
