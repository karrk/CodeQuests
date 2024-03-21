namespace Study
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input1 = Convert.ToInt32(Console.ReadLine().ToString());

            List<int[]> list = new List<int[]>();

            for (int i = 0; i < input1; i++)
            {
                string[] s = Console.ReadLine().Split();
                list.Add(new int[2] { Convert.ToInt32(s[0]), Convert.ToInt32(s[1]) });
            }

            foreach (int[] item in list)
            {
                Console.WriteLine(item[0] + item[1]);
            }

        }
    }
}
