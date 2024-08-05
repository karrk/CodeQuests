while (true)
{
    string[] input = Console.ReadLine().Split(' ');
    
    if(input[0] == input[1])
        break;

    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    if(a % b == 0)
        System.Console.WriteLine("multiple");
    else if(b % a == 0)
        System.Console.WriteLine("factor");
    else
        System.Console.WriteLine("neither");
}