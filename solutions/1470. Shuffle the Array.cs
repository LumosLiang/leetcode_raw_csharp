public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int len = nums.Count();
        var res = new int[len];
        int l = 0;
        int r = n;
        
        for(int i = 0; i < len; i++)
        {
            if(i % 2 == 0)
            {
                res[i] = nums[l];
                l++;
            }
            else
            {
                res[i] = nums[r];
                r++;
            }
        }
        return res; 
    }
}
