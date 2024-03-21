public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int pivot1 = nums[nums.Length - 1], pivot2 = nums[nums.Length - 1];

        //감소되는시점을 찾아 피벗잡기
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i == 0) // 감소되는 시점이없다
            {
                Reverse(nums, 0, nums.Length - 1);
                return;
            }

            else if (nums[i] > nums[i-1])
            {
                pivot1 = i-1;
                pivot2 = nums[i-1];
                break;
            }
            
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] > pivot2)
            {
                int temp = nums[pivot1];
                nums[pivot1] = nums[i];
                nums[i] = temp;
                break;
            }
        }

        Reverse(nums, pivot1+1, nums.Length-1);
    }

    int[] Reverse(int[] arr, int start, int end)
    {
        while (true)
        {
            if (start >= end)
                break;

            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }

        return arr;
    }
}