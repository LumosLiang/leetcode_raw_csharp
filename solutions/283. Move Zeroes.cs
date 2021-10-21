public class Solution {
    public void MoveZeroes(int[] nums)
    {
        int slow = 0, fast = 0;
        while (fast < nums.Length)
        {
            if (nums[fast] != 0)
            {
                nums[slow] = nums[fast];
                slow++;
            }
            fast++;
        }
        while (slow < nums.Length)
        {
            nums[slow] = 0;
            slow++;
        }
    }
}
