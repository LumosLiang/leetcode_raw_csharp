public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        
        if(intervals is null || intervals.Length == 0) return new int[][]{newInterval};

        List<int []> res = new List<int []>();

        for(int i = 0; i < intervals.Length ;i++)
        {
            var curr = intervals[i];
            if(newInterval[1] < curr[0])
            {
                res.Add(newInterval);
                for(int j = i; j < intervals.Length ;j++)
                    res.Add(intervals[j]);
                return res.ToArray();
            }
            else if(newInterval[0] > curr[1])
            {
                res.Add(curr);
            }
            else
            {
                newInterval = new int[]{Math.Min(newInterval[0], curr[0]), Math.Max(newInterval[1], curr[1])};
            }
        }
        
        res.Add(newInterval);

        return res.ToArray();
    }
}