namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i < input+1; i++)
            {
                for (int x = input; x > i; x--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
