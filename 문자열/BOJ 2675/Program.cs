using System;
using System.Collections.Generic;
using System.Text;

namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();

            int _case = int.Parse(Console.ReadLine());

            
            string target;

            for (int i = 0; i < _case; i++)
            {
                string result = "";
                string[] input2 = Console.ReadLine().Split();
                int count = int.Parse(input2[0]);

                for (int j = 0; j < input2[1].Length; j++)
                {
                    target = input2[1].Substring(j, 1);

                    for (int k = 0; k < count; k++)
                    {
                        result += target;
                    }
                }

                answer.AppendLine(result);
            }

            Console.WriteLine(answer);

        }
    }
}
