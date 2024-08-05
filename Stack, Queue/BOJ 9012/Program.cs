int count = int.Parse(Console.ReadLine());

Stack<char> stack = new Stack<char>();

for (int i = 0; i < count; i++)
{
    string input = Console.ReadLine();
    bool isMiss = false;

    for (int j = 0; j < input.Length; j++)
    {
        if(input[j] == '(')
            stack.Push(')');
        else
        {
            if(stack.Count > 0)
                stack.Pop();
            else
            {
                isMiss = true;
                break;
            }
        }
    }

    if(!isMiss && stack.Count == 0)
        System.Console.WriteLine("YES");
    else
        System.Console.WriteLine("NO");

    stack.Clear();
}