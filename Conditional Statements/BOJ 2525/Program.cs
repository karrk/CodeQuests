namespace Test
{
    class Study1
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int alpha = int.Parse(Console.ReadLine());

            int _hour = int.Parse(input[0]);
            int _minute = int.Parse(input[1]) + alpha;

            while (_hour >= 24 || _minute >= 60)
            {
                if (_minute >= 60)
                {
                    _hour++;
                    _minute -= 60;
                }
                if (_hour >= 24)
                {
                    _hour -= 24;
                }
            }
            DateTime time = new DateTime(1, 1, 1, _hour, _minute, 0);


            Console.WriteLine($"{time.Hour} {time.Minute}");
        }
    }
}
