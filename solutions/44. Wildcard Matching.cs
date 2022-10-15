public class Solution {
    public bool IsMatch(string s, string p) {
        // return true;
        var dp = new int[s.Length + 1, p.Length + 1];
        dp[s.Length, p.Length] = 1;
        return Helper2(0, 0, s, p, dp); 
    }
    
    public bool Helper2(int p1, int p2, string s, string p, int[,] dp)
    {
        if(dp[p1, p2] == 0)
        {
            if(p1 < s.Length && p2 < p.Length && (s[p1] == p[p2] || p[p2] == '?'))
                dp[p1, p2] = Helper2(p1 + 1, p2 + 1, s, p, dp)? 1:-1;
        
            else if(p2 < p.Length && p[p2] == '*')
            {
                bool temp = Helper2(p1, p2 + 1, s, p, dp);
                if(p1 < s.Length)
                    temp = temp || Helper2(p1 + 1, p2 + 1, s, p, dp) || Helper2(p1 + 1, p2, s, p, dp);
                dp[p1, p2] = temp? 1:-1;
            }
        }
        return dp[p1, p2] == 1? true:false;
    }
    
    public bool Helper(int p1, int p2, string s, string p)
    {
        if(p2 == p.Length && p1 == s.Length)
            return true;
        
        if(p1 < s.Length && p2 < p.Length && (s[p1] == p[p2] || p[p2] == '?'))
            return Helper(p1 + 1, p2 + 1, s, p);
        
        if(p2 < p.Length && p[p2] == '*')
        {
            bool temp = Helper(p1, p2 + 1, s, p);
            if(p1 < s.Length)
                temp = temp || Helper(p1 + 1, p2 + 1, s, p) || Helper(p1 + 1, p2, s, p);
            return temp;
        }
        
        return false;
    }
}
​
// base1: p1 == , p2 == 
//     return true
​
//     s[p1] == p[]
//         return Helrp
    
//     if p[] == ?
//         return helper
        
//     if p[] == *
        
//         return helper(+1, +1) or Helper(left, +1)
        
//     return false;
        
        
​
​
