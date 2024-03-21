using System;
using System.Text;

namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();

            string[] s = Console.ReadLine().Split();

            string[] items = Console.ReadLine().Split();

            for (int i = 0; i < int.Parse(s[0]); i++)
            {
                if (int.Parse(items[i]) < int.Parse(s[1]))
                    answer.Append($"{items[i]} ");
            }

            Console.WriteLine(answer);
        }
    }
}
