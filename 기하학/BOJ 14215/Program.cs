int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int max = arr.Max();
int others = arr.Sum() - max;

if(others > max)
    System.Console.WriteLine(others + max);
else
{
    System.Console.WriteLine(others+others-1);
}
