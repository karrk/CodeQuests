int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int[,] arr = new int[input[0],input[1]];

for (int i = 0; i < arr.GetLength(0); i++)
{
    string input2 = Console.ReadLine();

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if(input2[j] == '1')
            arr[i,j] = int.MaxValue;
    }
}

arr[0,0] = 1;

Queue<(int,int)> q = new Queue<(int,int)>();

q.Enqueue((0,0));

while (true)
{
    if(q.Count <= 0)
        break;

    (int,int) temp = q.Dequeue();

    int x = temp.Item1;
    int y = temp.Item2;

    if(x+1 < input[0] && arr[x+1,y] > arr[x,y]+1 )
    {
        arr[x+1,y] = arr[x,y]+1;
        q.Enqueue((x+1,y));
    }

    if(x-1 >= 0 && arr[x-1,y] > arr[x,y]+1)
    {
        arr[x-1,y] = arr[x,y]+1;
        q.Enqueue((x-1,y));
    }

    if(y+1 < input[1] && arr[x,y+1] > arr[x,y]+1)
    {
        arr[x,y+1] = arr[x,y]+1;
        q.Enqueue((x,y+1));
    }
    
    if(y-1 >= 0 && arr[x,y-1] > arr[x,y]+1)
    {
        arr[x,y-1] = arr[x,y]+1;
        q.Enqueue((x,y-1));
    }
}

System.Console.WriteLine(arr[input[0]-1,input[1]-1]);