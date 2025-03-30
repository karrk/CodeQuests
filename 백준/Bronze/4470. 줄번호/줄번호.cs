namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {Console.ReadLine()}");
            }
        }
    }
}
