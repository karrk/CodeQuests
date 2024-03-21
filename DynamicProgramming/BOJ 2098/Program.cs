int cities = int.Parse(Console.ReadLine());

int[][] costs = new int[cities][];

int max = (1 << cities) - 1;

long[,] dp = new long[cities, (1 << cities)];

int start = 0;

for (int i = 0; i < cities; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    int[] arr = new int[input.Length];

    for (int j = 0; j < input.Length; j++)
    {
        arr[j] = int.Parse(input[j]);
    }

    costs[i] = arr;
}

for (int i = 0; i < dp.GetLength(0); i++)
{
    for (int j = 0; j < dp.GetLongLength(1); j++)
    {
        dp[i, j] = -1;
    }
}

long minCost = TSP_Recursion(start, 1);

Console.WriteLine(minCost);

long TSP_Recursion(int target, int visited) // 0~3 , 1000 , 0001
{
    if(visited == max)
    {
        if (costs[target][start] == 0)
            return int.MaxValue;

        dp[start, max] = costs[target][start];
            return dp[start, max];
    }

    if (dp[target, visited] != -1) // dp[0][0001]
        return dp[target, visited];

    long cost = int.MaxValue;

    for (int i = 0; i < costs.GetLength(0); i++)
    {
        if ((visited & 1 << i) != 0)
            continue;

        if (costs[target][i] == 0)
            continue;

        //g(i,s[]) = min (w[i,j]) + g(j,[j-s])
        long temp1 = costs[target][i];
        long temp2 = TSP_Recursion(i, visited + (1 << i)); // 최저값

        if (cost > temp1 + temp2)
            cost = temp1 + temp2;
            
    }
    dp[target, visited] = cost;
    return dp[target, visited];
}