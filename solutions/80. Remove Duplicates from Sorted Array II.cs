public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int slow = 0, cnt = 1;
        
        for(int fast = 1; fast < nums.Length; fast++)
        {
            if(nums[fast] == nums[slow] && cnt < 2)
            {
                slow++;
                nums[slow] = nums[fast];
                cnt++;
            }
            else if(nums[fast] != nums[slow])
            {
                slow++;
                nums[slow] = nums[fast];
                cnt = 1;
            }
        }
        
        return slow + 1;
        
    }
}
