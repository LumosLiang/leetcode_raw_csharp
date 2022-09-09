public class Solution {
    public int FirstMissingPositive(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            while (nums[i] != i + 1)
            {
                int idx = nums[i] - 1;
                if (idx < nums.Length && idx >= 0 && nums[i] != nums[idx])
                {
                    int temp = nums[idx];
                    nums[idx] = nums[i];
                    nums[i] = temp;
                }
                else
                    break;
​
            }
        }
​
        for (int i = 0; i < nums.Length; i++)
        {
            if (i + 1 != nums[i]) return i + 1;
        }
​
        return nums.Length + 1;
    }
}
​
​
​
