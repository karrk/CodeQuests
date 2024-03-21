Stack<char> stack = new Stack<char>();

while (true)
{
    string input = Console.ReadLine();
    bool isMiss = false;

    if(input.Length == 1 && input[input.Length-1] == '.')
        break;

    for (int i = 0; i < input.Length; i++)
    {
        if(input[i] == '(')
            stack.Push(')');
        else if(input[i] == ')')
            {
                if(stack.Count <= 0 || stack.Pop() != ')')
                {
                    isMiss = true;
                    break;
                }
                else
                    continue;
            }

        else if(input[i] == '[')
            stack.Push(']');

        else if(input[i] == ']')
            {
                if(stack.Count <= 0 || stack.Pop() != ']')
                {
                    isMiss = true;
                    break;
                }
                else
                    continue;
            }
    }

    if(!isMiss && stack.Count == 0)
        System.Console.WriteLine("yes");
    else
        System.Console.WriteLine("no");

    stack.Clear(); 
}