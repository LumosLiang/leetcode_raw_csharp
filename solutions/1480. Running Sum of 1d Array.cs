public class Solution {
    public int[] RunningSum(int[] nums) {
        
        for(int i = 1; i < nums.Count(); i++){
            nums[i] += nums[i - 1];
        }
        return nums;
    }
}
