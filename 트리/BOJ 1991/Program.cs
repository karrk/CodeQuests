using System.Text;

int total = int.Parse(Console.ReadLine());

Dictionary<char,char[]> dic = new Dictionary<char, char[]>();

for (int i = 0; i < total; i++)
{
    char[] input = Array.ConvertAll(Console.ReadLine().Split(' '),char.Parse);

    dic.Add(input[0], new char[]{input[1],input[2]});
}

StringBuilder sb = new StringBuilder();

string PreOrder(char c)
{
    if(c == '.')
        return null;

    return c + PreOrder(dic[c][0]) + PreOrder(dic[c][1]);
}

string InOrder(char c)
{
    if(c == '.')
        return null;

    return InOrder(dic[c][0]) + c + InOrder(dic[c][1]);
}

string PostOrder(char c)
{
    if(c == '.')
        return null;

    return PostOrder(dic[c][0]) + PostOrder(dic[c][1]) + c;
}

sb.AppendLine(PreOrder('A'));
sb.AppendLine(InOrder('A'));
sb.Append(PostOrder('A'));

System.Console.WriteLine(sb);