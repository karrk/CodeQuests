using System;
using System.Text;

namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();

            int result = 1;

            while (result != 0)
            {
                string[] s = Console.ReadLine().Split();
                result = int.Parse(s[0]) + int.Parse(s[1]);
                if (result != 0)
                    answer.AppendLine(result.ToString());
            }

            Console.WriteLine(answer);
        }
    }
}
