public class Solution {
    public int[] BuildArray(int[] nums) {
        
        int shiftCount = 12;
        int mask = (1<<shiftCount) - 1; // 0b1x12

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i]++;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            int targetNum = nums[nums[i]-1] > 1000 ? 
                (nums[nums[i]-1]>>shiftCount) : nums[nums[i]-1];

            nums[i] = (nums[i]<<shiftCount) | targetNum;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] & mask;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i]--;
        }

        return nums;
    }
}