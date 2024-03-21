int count = int.Parse(Console.ReadLine());
int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

double max = 0;
double sum = 0;

for (int i = 0; i < scores.Length; i++)
{
    if(scores[i] > max)
        max = scores[i];

    sum += scores[i];
}

System.Console.WriteLine(((sum/max)*100)/count);