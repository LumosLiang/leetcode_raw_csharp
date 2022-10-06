​
// 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
​
public class Solution {
    public int TrailingZeroes(int n) {
        
        int res = 0;
        
        for(int i = 1; i <= n; i++)
        {
            int temp = i;
            while(temp % 5 == 0)
            {
                temp /= 5;
                res++;
            }
        }
        return res;
    }
}
