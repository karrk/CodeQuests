namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            for (int i = 0; i < 4; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum/60);
            Console.WriteLine(sum - (sum / 60) * 60);
        }
    }
}
