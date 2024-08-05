while (true)
{
    int input = int.Parse(Console.ReadLine());

    if(input == -1)
        break;

    List<int> searchNums = new List<int>();

    for (int i = 1; i < input-1; i++)
    {
        if(input % i == 0)
        {
            searchNums.Add(i);
        }
    }

    if(searchNums.Sum() == input)
    {
        System.Console.Write($"{input} = ");
        for (int i = 0; i < searchNums.Count; i++)
        {
            System.Console.Write($"{searchNums[i]} ");

            if(i != searchNums.Count-1)
                System.Console.Write("+ ");
        }
        System.Console.WriteLine();
    }
    else
        System.Console.WriteLine($"{input} is NOT perfect.");

}