public class Solution {
    public int CountSubstrings(string s) {
        
        int res = 0;
            
        for(int i = 0; i < s.Length; i++)
            res += (helper(s, i, i) + helper(s, i, i + 1));
        
        return res;
    }
    
    public int helper(string s, int left, int right)
    {
        int res = 0;
​
        while(left >= 0 && right < s.Length && s[left] == s[right])
        {
            res++;
            left--;
            right++;
        }
        return res;
    }
    
}
