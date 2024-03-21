int n = int.Parse(Console.ReadLine());

int[,] arr = new int[n+1,n+1];

for (int i = 1; i < n+1; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

    for (int j = 1; j < n+1; j++)
    {
        if(input[j-1] == 1)
        arr[i,j] = 1;
    }
}

int zero = 0;
int one = 0;

void Slice(int sx, int ex, int sy, int ey)
{
    //모두 같은 색이라면 기저
    int color = arr[sy,sx];
    bool missMatch = false;

    for (int i = sy; i < ey; i++)
    {
        for (int j = sx; j < ex; j++)
        {
            if(arr[i,j] != color)
            {
                missMatch = true;
                break;
            }
        }
    }

    if(!missMatch)
    {
        if(color == 1)
            one++;
        else
            zero++;

        return;
    }

    int mid = (ex - sx) / 2;
    // 2
    // 1 5 1 5
    
    // 1 3 1 3
    // 3 5 1 3 = > 우측위 4512 mid = 1 // 4 5 1 2
    // 1 3 3 5
    // 3 5 3 5

    Slice(sx , sx + mid , sy , sy + mid);
    Slice(sx + mid , ex , sy , sy + mid);
    Slice(sx , sx + mid , sy + mid , ey);
    Slice(sx + mid , ex , sy + mid , ey);
}

Slice(1,n+1,1,n+1);

System.Console.WriteLine($"{zero}\n{one}");