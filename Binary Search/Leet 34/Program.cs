public class Solution {
    public int[] SearchRange(int[] nums, int target) {
         int[] result = { -1, -1 };

        if (nums.Length == 0)
            return result;

        int start = 0;
        int end = nums.Length - 1;

        while (true)
        {
            if(start >= end)
                break;

            int mid = (start + end) / 2;
            
            if (nums[mid] < target) 
                start = mid + 1;
            
            else end = mid;
        }

        if (nums[start] != target) 
            return result;
        
        result[0] = start;

        end = nums.Length;

        while (true)
        {
            if(start >= end)
                break;

            int mid = (start + end) / 2;
            
            if (nums[mid] == target) 
                start = mid + 1;
            
            else end = mid;
        }

        result[1] = start - 1;
        return result;
    }
}