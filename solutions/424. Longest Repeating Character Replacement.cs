public class Solution {
    public int CharacterReplacement(string s, int k) {
       
        int l = 0;
        var hash = new Dictionary<int, int>();
        int res = 0;
        
        for(int r = 0; r < s.Length; r++)
        {
            if(hash.ContainsKey(s[r])) hash[s[r]]++;
            else hash[s[r]] = 1;
            
            while(r - l + 1 - hash.Values.Max() > k)
            {
                hash[s[l]]--;
                l++;
            }
            
            res = Math.Max(res, r - l + 1);
        }
        
        return res;
        
    }
}
