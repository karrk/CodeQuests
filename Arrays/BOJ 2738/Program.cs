string[] input = Console.ReadLine().Split(' ');

int r = int.Parse(input[0]);
int c = int.Parse(input[1]);

int[,] a = new int[r,c];
int[,] b = new int[r,c];

for (int i = 0; i < 2; i++)
{
    int[,] temp;

    if(i == 0)
        temp = a;
    else
        temp = b;

    for (int j = 0; j < r; j++)
    {
        input = Console.ReadLine().Split(' ');

        for (int k = 0; k < c; k++)
        {
            temp[j,k] = int.Parse(input[k]);
        }
    }
}

for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        b[i,j] += a[i,j];
        System.Console.Write($"{b[i,j]} ");
    }
    System.Console.WriteLine();
}