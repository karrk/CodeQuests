string[] input = Console.ReadLine().Split(' ');

int num = int.Parse(input[0]);
int k = int.Parse(input[1]);

int count = 1;
int searchNum = 0;

for (int i = 1; i <= num; i++)
{
    if(num % i == 0)
    {
        searchNum = i;

        if(count == k)
        {
            System.Console.WriteLine(searchNum);
            return;
        }

        count++;
    }
}

System.Console.WriteLine(0);