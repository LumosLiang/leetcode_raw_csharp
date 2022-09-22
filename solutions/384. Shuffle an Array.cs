public class Solution
{
    public readonly int[] originalNums;
    public readonly int[] currNums;
    public Random picker;
​
    public Solution(int[] nums)
    {
        originalNums = nums;
        currNums = (int[]) nums.Clone();
        picker = new Random();
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
