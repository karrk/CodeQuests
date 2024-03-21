public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        if(intervals.Length == 1)
            return intervals;

        List<int[]> list = new List<int[]>();

        Array.Sort(intervals, (a,b) => { return a[0]-b[0];});

        list.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            int[] cur = intervals[i];
            int[] prev = list[list.Count-1];

            if(cur[0] <= prev[1])
                prev[1] = Math.Max(cur[1],prev[1]);
            else
                list.Add(cur);
        }

        return list.ToArray();
    }
}