public class Solution {
    public int CountPrimes(int n) {
     
        return Solution2(n);
    }
    
    // dp
    //
    public int Solution1(int n) {
     
        var dp = new int[n];
        
        for(int i = 2; i < n; i++)
        {
            if(dp[i] == 0)
            {
                for(int j = 2 * i; j < n; j += i)
                    dp[j] = 1;
            }
        }
        
        return n >= 2? n - dp.Sum() - 2:0;
        
    }
    
    // sieve of eratosthenes,
    // 
    
    public int Solution2(int n) {
     
        var dp = new int[n];
        
        for(int i = 2; i < Math.Sqrt(n); i++)
        {
            if(dp[i] == 0)
            {
                for(int j = i * i; j < n; j += i)
                    dp[j] = 1;
            }
        }
        
        return n >= 2? n - dp.Sum() - 2:0;  
    }
}
