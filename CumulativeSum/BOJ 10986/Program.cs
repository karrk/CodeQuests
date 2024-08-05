long[] input = Array.ConvertAll(Console.ReadLine().Split(' '),long.Parse);

long[] sumArr = new long[input[0]+1];
long m = input[1];
long[] another = new long[m];

input = Array.ConvertAll(Console.ReadLine().Split(' '),long.Parse);

sumArr[1] = input[0];

for (int i = 2; i < sumArr.Length; i++)
{
    sumArr[i] = input[i-1] + sumArr[i-1];
}

long count = 0;

for (int i = 1; i < sumArr.Length; i++)
{
    sumArr[i] %= m;
    
    if(sumArr[i] == 0)
        count++;

    another[sumArr[i]]++;
}

for (int i = 0; i < another.Length; i++)
{
    if(another[i] < 2)
        continue;

    count += (another[i]*(another[i]-1))/2;
}

System.Console.WriteLine(count);
