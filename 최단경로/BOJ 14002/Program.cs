Console.ReadLine();
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] dp = new int[arr.Length];
int[] path = new int[arr.Length];

int max = 1;
int longestIdx = 0;
Array.Fill(dp, 1);
path[0] = -1;

for (int i = 1; i < arr.Length; i++)
{
    int stopIdx = -1;

    for (int j = 0; j < i; j++)
    {
        if (arr[i] > arr[j] && dp[i] < dp[j] + 1)
        {
            dp[i] = dp[j] + 1;
            stopIdx = j;
        }
    }

    if (max < dp[i])
    {
        max = dp[i];
        longestIdx = i;
    }


    if (stopIdx == -1)
    {
        path[i] = -1;
        continue;
    }

    if (arr[i] > arr[stopIdx])
    {
        path[i] = stopIdx;
    }
}

System.Console.WriteLine(dp[longestIdx]);

Stack<int> st = new Stack<int>();

while (true)
{
    st.Push(arr[longestIdx]);

    longestIdx = path[longestIdx];

    if(longestIdx == -1)
        break;
}

while (true)
{
    if(st.Count <= 0)
        break;

    System.Console.Write($"{st.Pop()} ");
}