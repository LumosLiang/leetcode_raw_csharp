public class Solution {
    public int CharacterReplacement(string s, int k) {
       
        int l = 0;
        var hash = new Dictionary<int, int>();
        int res = 0;
        int maxValue = 0;
        
        for(int r = 0; r < s.Length; r++)
        {
            if(hash.ContainsKey(s[r])) hash[s[r]]++;
            else hash[s[r]] = 1;
            
            maxValue = Math.Max(maxValue, hash[s[r]]);
            
            if(r - l + 1 - maxValue > k)
            {
                hash[s[l]]--;
                l++;
            }
            
            res = Math.Max(res, r - l + 1);
        }
        
        return res;
        
    }
}
