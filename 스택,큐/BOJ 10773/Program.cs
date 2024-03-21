StreamReader reader = new StreamReader(Console.OpenStandardInput());

Stack<long> stack = new Stack<long>();
int count = int.Parse(reader.ReadLine());

for (int i = 0; i < count; i++)
{
    long value = long.Parse(reader.ReadLine());

    if(value > 0)
        stack.Push(value);
    else
        stack.Pop();
}

System.Console.WriteLine(stack.Sum());