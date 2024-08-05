using System.Text;

StringBuilder sb = new StringBuilder();

int input = int.Parse(Console.ReadLine());

sb.AppendLine($"{(int)(Math.Pow(2,input)-1)}");

HanoiTower(input,1,2,3);

System.Console.WriteLine(sb);

void HanoiTower(int n, int start, int temp, int target)
{
    if(n <= 1)
    {
        sb.AppendLine($"{start} {target}");
        return;
    }

    HanoiTower(n-1,start,target,temp);
    HanoiTower(1,start,temp,target);
    HanoiTower(n-1,temp,start,target);
}