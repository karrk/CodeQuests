namespace Study
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var list = input.Select(x => int.Parse(x)).ToList();

            int count = 1;
            int sameNum = 0;
            int bestNum = 0;

            foreach (var item in list)
            {
                if(bestNum < item)
                {
                    bestNum = item;
                }
            }

            for (int i = 1; i < list.Count; i++)
            {
                if (list[0] == list[i])
                {
                    sameNum = list[i];
                    count++;
                }
            }

            if (list[1] == list[2])
            {
                count++;
                if (sameNum == 0)
                    sameNum = list[2];
            }

            switch (count)
            {
                case 1: // 일치하는게 없다면
                    Console.WriteLine(bestNum*100);
                    break;
                case 2:
                    Console.WriteLine((sameNum*100)+1000);
                    break;
                default:
                    Console.WriteLine((sameNum * 1000) + 10000);
                    break;
            }
        }
    }
}
