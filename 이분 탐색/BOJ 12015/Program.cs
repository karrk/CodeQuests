Console.ReadLine();
int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
List<int> lis = new List<int>(){arr[0]};

for (int i = 1; i < arr.Length; i++)
{
    if(arr[i] > lis[lis.Count-1])
        lis.Add(arr[i]);

    else
        {
            int left = 0;
            int right = lis.Count -1;

            int mid = 0;

            while (true)
            {
                if(left >= right)
                    break;
                
                mid = (right + left) / 2;

                if(lis[mid] < arr[i])
                    left = mid+1;
                else
                    right = mid;
            }

            if(lis[left] >= arr[i])
                lis[left] = arr[i];
        }
}

System.Console.WriteLine(lis.Count);