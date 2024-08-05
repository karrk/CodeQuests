using System;
using System.Collections.Generic;


namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] array = new int[2];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(input[i]);
            }

            if(array[0]>array[1])
                Console.WriteLine(">");
            else if(array[0]<array[1])
                Console.WriteLine("<");
            else if(array[0]==array[1])
                Console.WriteLine("==");
        }
    }
}
