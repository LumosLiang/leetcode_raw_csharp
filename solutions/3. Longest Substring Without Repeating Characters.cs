public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        int left = 0, res = 0;
        Dictionary<int, int> window = new Dictionary<int, int>();
​
        for (int right = 0; right < s.Length; right++) 
        {
            if (window.ContainsKey(s[right]))
            {
                left = Math.Max(left, window[s[right]] + 1);
            }
​
            window[s[right]] = right;
            res = Math.Max(res, right - left + 1);
        }
        return res;
        
    }
}
​
