using System.Text;

namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split();
                answer.AppendLine((int.Parse(s[0]) + int.Parse(s[1])).ToString());
            }

            Console.WriteLine(answer);


        }
    }
}
