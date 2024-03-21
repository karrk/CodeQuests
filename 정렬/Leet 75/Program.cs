public class Solution {
    public void SortColors(int[] nums) {
        int zero = 0, one = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
                zero++;
            else if(nums[i] == 1)
                one += 2;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if(zero != 0)
            {
                nums[i] = 0;
                zero -= 1;
            }
                
            else if(one != 0)
            {
                nums[i] = 1;
                one -= 2;
            }

            else
            {
                nums[i] = 2;
            }
        }
    }
}