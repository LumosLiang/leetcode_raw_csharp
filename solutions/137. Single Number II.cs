public class Solution {
    public int SingleNumber(int[] nums) {
        
        int res = 0;
        
        for(int i = 0; i < 32; i++)
        {
            int temp = 0;
            foreach(var num in nums)
            {
                if((num >> i & 1) == 1)
                    temp += 1;
            }
            
            res += (temp % 3) << i;
        }
        
        return res;
    }
}
