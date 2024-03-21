public class Solution {
    public int Jump(int[] nums) {
        if(nums.Length == 1)
            return 0;

        int range = nums[0];
        int nextRange = nums[0];

        int count = 1;


        for (int i = 1; i < nums.Length; i++)
        {
            if(i > range)
            {
                count++;
                range = nextRange;

                if(range >= nums.Length - 1)
                    return count;
            }

            nextRange = Math.Max(nextRange,i + nums[i]);

        }

        return count;
    }
}