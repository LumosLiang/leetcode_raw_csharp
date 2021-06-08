public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        int res = int.MinValue;
        foreach(int[] account in accounts)
        {
            int temp = account.Sum();
            res = Math.Max(temp, res);
        }
        
        return res;
    }
}
