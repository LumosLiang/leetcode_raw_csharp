public class Solution {
    public int StrStr(string haystack, string needle) {
        
        var table = GetTable(needle);
        
        int p2 = 0;
        
        for(int p1 = 0; p1 < haystack.Length; p1++)
        {   
            while(p2 > 0 && haystack[p1] != needle[p2])
            {
                p2 = table[p2 - 1];
                
            }
            if(haystack[p1] == needle[p2])
            {
                p2++;   
            }
            if(p2 == needle.Length)
                return p1 - p2 + 1;
        }
        
        return -1;
    }
    
    public int[] GetTable(string s)
    {
        int[] table = new int[s.Length];
        
        int left = 0;
        
        for(int right = 1; right < s.Length; right++)
        {
            while(left > 0 && s[left] != s[right])
            {
                left = table[left - 1];
            }
            
            if(s[left] == s[right])
            {
                left += 1;
                table[right] = left;   
            }
        }
        
        return table;
        
    }
}
​
​
