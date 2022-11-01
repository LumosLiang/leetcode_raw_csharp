public class Solution {
    public int MySqrt(int x) {
        double res = Helper2(x);
        // Console.WriteLine(res);
        return (int)Math.Floor(res);
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
    
    // assume that accuracy is 0.001
    public double Helper2(int x)
    {
        double accuracy = 0.001;
        double unitCount = x / accuracy;
        double l = 0, r = unitCount;
        
        while(l < r)
        {
            double mid = l + (r - l) / 2;
            double temp = (mid * accuracy) * (mid * accuracy);
            
            if(temp < x)
                l = mid + 1;
            else
                r = mid;
        } 
        
        return l * accuracy;
    }
}
