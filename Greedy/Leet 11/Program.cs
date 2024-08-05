public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int maxHeight = 0;

        for (int i = 0; i < height.Length; i++)
        {
            if(maxHeight > height[i])
                continue;

            int h = height[i];
            int maxTargetHeight = 0;

            for (int j = height.Length-1; j >= i+1; j--)
            {
                int targetHeight = height[j];

                if(maxTargetHeight > targetHeight)
                    continue;

                maxTargetHeight = targetHeight;

                targetHeight = Math.Min(h,height[j]);
                
                int width = j-i;
                int area = targetHeight*width;

                if(max < area)
                    max = area;

                if(targetHeight == h)
                {
                    maxHeight = h;
                    break;
                }
                    
                    
            }
        }

        return max;
    }
}