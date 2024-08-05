public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> list = new List<int[]>();

        if(intervals.Length == 0)
        {
            list.Add(newInterval);
            return list.ToArray();
        }

        bool isInserted = false;

        int[] startArr;
        int startIdx = 1;

        if (intervals[0][0] >= newInterval[0])
        {
            startArr = newInterval;
            startIdx = 0;
            isInserted = true;
        }
        else
            startArr = intervals[0];

        list.Add(startArr);

        for (int i = startIdx; i < intervals.Length; i++)
        {
            int[] cur = intervals[i];
            int[] prev = list[list.Count - 1];

            if (!isInserted && cur[0] >= newInterval[0])
            {
                cur = newInterval;
                isInserted = true;
                i--;
            }

            if (cur[0] <= prev[1])
                prev[1] = Math.Max(cur[1], prev[1]);
            else
                list.Add(cur);
        }

        if(!isInserted)
        {
            if(newInterval[0] <= list[list.Count-1][1])
                list[list.Count-1][1] =
                Math.Max(newInterval[1],list[list.Count-1][1]);
            else
                list.Add(newInterval);
        }
            

        return list.ToArray();
    }
}