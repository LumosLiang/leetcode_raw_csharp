public class Solution {
    public int MaxProduct(int[] nums) {
     
        var dp = new int[nums.Length, 2];
        
        dp[0, 0] = nums[0];
        dp[0, 1] = nums[0];
        var res = Math.Max(dp[0, 0], dp[0, 1]);
        // Console.WriteLine((dp[0, 0], dp[0, 1]));
        for(int i = 1; i <nums.Length; i++)
        {
            dp[i, 0] = Math.Max(nums[i], Math.Max(nums[i] * dp[i - 1, 0], nums[i] * dp[i - 1, 1]));
            dp[i, 1] = Math.Min(nums[i], Math.Min(nums[i] * dp[i - 1, 0], nums[i] * dp[i - 1, 1]));
            
            // Console.WriteLine((dp[i, 0], dp[i, 1]));
            res = Math.Max(res, dp[i, 0]);
        }
        
        return res;
        
    }
}
