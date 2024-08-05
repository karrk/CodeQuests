string[] input = Console.ReadLine().Split(' ');

int workers = int.Parse(input[0]);
int taskes = int.Parse(input[1]);

int[] process = new int[taskes];

//Dictionary<int, int[]> stats = new Dictionary<int, int[]>();
// 일 갯수 , 처리가능한 일

List<int[]> stats = new List<int[]>();
int[] chance = new int[taskes];

for (int i = 0; i < workers; i++)
{
    input = Console.ReadLine().Split(' ');

    int taskCount = int.Parse(input[0]);
    int[] tempArr = new int[taskCount];

    for (int j = 0; j < taskCount; j++)
    {
        tempArr[j] = int.Parse(input[j + 1]);
        chance[tempArr[j]-1]++;
    }

    Quick_Sort(tempArr, 0, tempArr.Length -1 );

    stats.Add(tempArr);
}

stats.Sort((x,y)=>x.Length.CompareTo(y.Length));

int count = 0;

for (int i = 0; i < stats.Count; i++)
{
    int[] arr = stats[i];

    int minTaskChance = int.MaxValue;
    int taskNum;
    int taskCount = -1;

    for (int j = 0; j < arr.Length; j++)
    {
        taskNum = arr[j];

        if (process[taskNum - 1] == -1)
            continue;

        if (chance[taskNum - 1] < minTaskChance)
        {
            minTaskChance = chance[taskNum - 1];
            taskCount = taskNum-1;
        }
    }

    if (minTaskChance == int.MaxValue)
        continue;

    process[taskCount] = -1;
    count++;

    for (int j = 0; j < arr.Length; j++)
    {
        chance[arr[j]-1] -= 1;
    }
}

Console.WriteLine(count);

void Quick_Sort(int[] arr, int low, int high)
{
    if (low < high)
    {
        int pivot = Partition(arr, low, high);

        Quick_Sort(arr, low, pivot - 1);
        Quick_Sort(arr, pivot + 1, high);
    }
}

int Partition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (arr[j] <= pivot)
        {
            i++;
            Swap(arr, i, j);
        }
    }

    Swap(arr, i + 1, high);
    return i + 1;
}

void Swap(int[] arr, int a, int b)
{
    int temp = arr[a];
    arr[a] = arr[b];
    arr[b] = temp;
}