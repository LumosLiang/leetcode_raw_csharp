public class Solution {
    public bool IsUgly(int n) {
     
        if(n == 0) return false;
        
        while(n % 2 == 0 || n % 3 == 0 || n % 5 == 0)
        {
            if(n % 2 == 0)
            {
                n /= 2;
                continue;
            }
            else if(n % 3 == 0)
            {
                n /= 3;
                continue;
            }
            else
            {
                n /= 5;
            }
        }
            
        return n == 1;
        
    }
}
