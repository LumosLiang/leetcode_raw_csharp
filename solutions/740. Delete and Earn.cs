public class Solution {
    public int DeleteAndEarn(int[] nums)
    {
        if (nums.Length == 1) return nums[0];
​
        int[] points = new int[10000],
              dp = new int[10000];
​
        foreach (int num in nums)
        {
            points[num] += num;
        }
​
        dp[0] = points[0];
        dp[1] = Math.Max(dp[0], points[1]);
​
        for (int i = 2; i < points.Length; i++)
        {
            dp[i] = Math.Max(points[i] + dp[i - 2], dp[i - 1]);
        }
​
        return dp[points.Length - 1];
​
    }
}
