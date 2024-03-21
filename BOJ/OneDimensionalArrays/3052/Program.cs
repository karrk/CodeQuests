using System;
using System.Collections.Generic;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            List<int> resultArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int result = arr[i] % 42;
                if (!resultArr.Contains(result))
                    resultArr.Add(result);
            }

            Console.WriteLine(resultArr.Count);
        }
    }
}
