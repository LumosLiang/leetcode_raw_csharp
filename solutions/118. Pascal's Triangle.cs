public class Solution {
    public IList<IList<int>> Generate(int numRows)
    {
​
        List<IList<int>> dp = new List<IList<int>>
        {
            new List<int> { 1 },
            new List<int> { 1, 1 }
        };
​
        if (numRows == 1) return new List<IList<int>>() { new List<int> { 1 } };
        if (numRows == 2) return dp;
​
        for (int i = 2; i < numRows; i++)
        {
            dp.Add(new List<int>(new int[i + 1]));
            dp[i][0] = 1;
            for (int j = 1; j < i; j++)
            {
                dp[i][j] = dp[i -1 ][j - 1] + dp[i - 1][j];
            }
            dp[i][i] = 1;
        }
​
        return dp;
    }
}
