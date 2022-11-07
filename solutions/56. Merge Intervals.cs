public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        if(intervals == null | intervals.Length == 1) return intervals;

        Array.Sort(intervals, (arr1, arr2) => arr1[0].CompareTo(arr2[0]));

        var res = new List<int[]>();
        res.Add(intervals[0]);

        for(int i = 1; i < intervals.Length; i++)
        {
            int[] curr = intervals[i];

            if(curr[0] > res[^1][1])
                res.Add(curr);
            else
                res[^1][1] = Math.Max(curr[1], res[^1][1]);
        }

        return res.ToArray();
    }
}

