public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hash = new Dictionary<int, int>();
        
        for(int i = 0; i< nums.Count(); i++)
        {
            if(hash.ContainsKey(nums[i]))
            {
                return new int[]{i, hash[nums[i]]};
            }
            else
            {
                if(!hash.ContainsKey(target - nums[i])) hash.Add(target - nums[i], i);
            }
        }
        return new int[2];
​
    }
}
