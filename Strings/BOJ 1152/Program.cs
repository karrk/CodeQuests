string[] input = Console.ReadLine().Split(' ');

int result = 0;

for (int i = 0; i < input.Length; i++)
{
    if(input[i].Length == 0)
        continue;
    
    result++;
}

System.Console.WriteLine(result);
