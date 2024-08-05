int count = int.Parse(Console.ReadLine());

List<char> list = new List<char>();

int answer = 0;

for (int i = 0; i < count; i++)
{
    string input = Console.ReadLine();
    
    char currentChar;
    char prevChar;

    answer++;

    for (int j = 0; j < input.Length; j++)
    {
        if(j == 0)
        {
            list.Add(input[j]);
            continue;
        }

        prevChar = input[j-1];
        currentChar = input[j];

        if(currentChar == prevChar)
            continue;

        if(!list.Contains(currentChar))
            list.Add(currentChar);
        else
        {
            answer--;
            break;
        }
    }

    list.Clear();
}

System.Console.WriteLine(answer);