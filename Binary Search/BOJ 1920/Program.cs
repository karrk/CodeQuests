using System.Text;

StringBuilder sb = new StringBuilder();

int count = int.Parse(Console.ReadLine());
long[] nums = Array.ConvertAll(Console.ReadLine().Split(' '),long.Parse);

Array.Sort(nums);

int searchCount = int.Parse(Console.ReadLine());
long[] searchNums = Array.ConvertAll(Console.ReadLine().Split(' '),long.Parse);

for (int i = 0; i < searchCount; i++)
{
    BinarySearch(searchNums[i]);
}

System.Console.WriteLine(sb.ToString());

void BinarySearch(long target)
{
    int start = 0;
    int end = count-1;

    while (true)
    {
        int mid = (start + end) / 2;

        if(nums[mid] == target)
        {
            sb.AppendLine("1");
            break;
        }

        if(start >= end)
        {
            sb.AppendLine("0");
            break;
        }

        if(nums[mid] < target)
            start = mid+1;

        else if(nums[mid] > target)
            end = mid-1;
    }
}