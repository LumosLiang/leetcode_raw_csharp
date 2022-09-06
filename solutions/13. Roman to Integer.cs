public class Solution {
    public int RomanToInt(string s)
    {
        Dictionary<char, int> table = new Dictionary<char, int>
        {
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
​
        int res = 0;
​
        for (int i = 0; i < s.Length - 1; i++)
        {
            int curr = table[s[i]], nxt = table[s[i + 1]];
​
            if (curr < nxt)
                res -= curr;
            else
                res += curr;
        }
​
        return res + table[s[s.Length - 1]];
    }
}
​
​
​
​
