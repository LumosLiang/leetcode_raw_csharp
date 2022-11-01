public class Solution {
    public int MySqrt(int x) {
        return Helper1(x);
    }
    
    public int Helper1(int x)
    {
        long l = 0, r = x;
        
        while(l < r)
        {
            long mid = l + (r - l) / 2;
​
            long temp = mid * mid;
            
            if(temp < x)
                l = mid + 1;
            else
                r = mid;
            
        } 
        return l*l == x? (int)l: (int)l - 1;
    }
    
//     public int Helper2(int x)
//     {
        
//     }
}
