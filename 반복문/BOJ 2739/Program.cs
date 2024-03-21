namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine().ToString());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{input} * {i} = {input*i}");
            }
        }
    }
}
