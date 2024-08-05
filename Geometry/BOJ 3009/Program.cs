string[] input;
List<int> xlist = new List<int>();
List<int> ylist = new List<int>();

for (int i = 0; i < 3; i++)
{
    input = Console.ReadLine().Split(' ');

    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    if(xlist.Contains(a))
        xlist.Remove(a);
    else
        xlist.Add(a);

    if(ylist.Contains(b))
        ylist.Remove(b);
    else
        ylist.Add(b);

}

System.Console.WriteLine($"{xlist[0]} {ylist[0]}");