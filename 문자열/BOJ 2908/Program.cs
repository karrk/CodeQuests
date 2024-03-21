string[] input = Console.ReadLine().Split(' ');

for (int i = 0; i < 2; i++)
{
    string str = $"{input[i][2]}{input[i][1]}{input[i][0]}";

    input[i] = str;
}

string result = int.Parse(input[0]) > int.Parse(input[1]) ? input[0] : input[1];
System.Console.WriteLine(result);