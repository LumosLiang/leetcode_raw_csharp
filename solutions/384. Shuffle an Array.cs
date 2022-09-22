public class Solution
{
    public readonly int[] originalNums;
    public readonly int[] currNums;
​
    public Solution(int[] nums)
    {
        originalNums = nums;
        currNums = (int[]) nums.Clone();
    }
​
    public int[] Reset()
    {
        return originalNums;
    }
​
    public int[] Shuffle()
    {
        for (int i = currNums.Length - 1; i > -1; i--)
        {
            var picker = new Random();
            var pick = picker.Next(i + 1);
​
            var temp = currNums[i];
            currNums[i] = currNums[pick];
            currNums[pick] = temp;
        }
​
        return currNums;
    }
​
}
​
/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */
