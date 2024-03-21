namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < input; i++)
            {
                result += i+1;
            }

            Console.WriteLine(result);
        }
    }
}
