using System.Text;

StringBuilder sb = new StringBuilder();

int count = int.Parse(Console.ReadLine());

int[] arr = new int[count];
int[] result = new int[count];

for (int i = 0; i < count; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

Partition(0,arr.Length-1);

for (int i = 0; i < arr.Length; i++)
{
    sb.AppendLine(arr[i].ToString());
}

System.Console.WriteLine(sb);

void Merge(int left, int right)
{
    int mid = (left + right) / 2;
    int i = left;
    int j = mid + 1;
    int k = left;

    while (true)
    {
        if( i > mid || j > right)
            break;

        if(arr[i] > arr[j])
        {
            result[k] = arr[j];
            j++;
        }
        else
        {
            result[k] = arr[i];
            i++;
        }

        k++;
    }

    if(i > mid)
    {
        while (true)
        {
            if(j > right)
                break;

            result[k] = arr[j];
            j++;
            k++;
        }
    }
    else
    {
        while (true)
        {
            if(i > mid)
                break;

            result[k] = arr[i];
            i++;
            k++;
        }
    }

    for (int a = left; a <= right; a++)
    {
        arr[a] = result[a];
    }
}

void Partition(int left, int right)
{
    int mid;

    if(left < right)
    {
        mid = (left + right) /2;
        Partition(left,mid);
        Partition(mid+1,right);
        Merge(left,right);
    }
}