int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int target = input[1];
int[] coins = new int[input[0]];

for (int i = 0; i < coins.Length; i++)
{
    coins[i] = int.Parse(Console.ReadLine());
}

int idx = coins.Length-1;
int count = 0;

while (true)
{
    if(target == 0 || idx < 0)
        break;

    if(coins[idx] > target)
    {
        idx--;
        continue;
    }

    while (true)
    {
        if(coins[idx] > target)
            break;

        target -= coins[idx];
        count++;
    }
    
    idx--;    
}

System.Console.WriteLine(count);