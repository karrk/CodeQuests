namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            int totalCost = int.Parse(Console.ReadLine());
            int totalCount = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < totalCount; i++)
            {
                string[] s = Console.ReadLine().Split();
                int cost = int.Parse(s[0]);
                int count = int.Parse(s[1]);
                result += cost * count;
            }

            if(totalCost == result)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
