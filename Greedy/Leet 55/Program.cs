public class Solution {
    public bool CanJump(int[] nums)
    {
        if(nums[0] == 0 && nums.Length > 1)
            return false;

        else if(nums.Length == 1)
            return true;

        int maxRange = nums[0];
        int nextRange = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if(maxRange < i)
            {
                maxRange = nextRange;

                if(maxRange < i)
                    return false;
            }

            nextRange = Math.Max(nextRange,i+nums[i]);
        }

        return true;
    }
}