int total = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(' ');
string target = Console.ReadLine();
int result = 0;

for (int i = 0; i < total; i++)
{
    if(input[i] == target)
        result++;
}

System.Console.WriteLine(result);

