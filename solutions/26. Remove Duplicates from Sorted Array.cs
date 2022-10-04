public class Solution {
    public int RemoveDuplicates(int[] nums) {
    
        int slow = 0;
        
        for(int fast = 1; fast < nums.Length; fast++)
        {
            if(nums[fast] != nums[slow])
            {
                slow++;
                nums[slow] = nums[fast];
            }
        }
        
        return slow + 1;
    }
}
