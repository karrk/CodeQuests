int total = int.Parse(Console.ReadLine());

for (int i = 0; i < total; i++)
{
    string input = Console.ReadLine();
    System.Console.Write($"{input[0]}{input[input.Length-1]}");
    System.Console.WriteLine();
}