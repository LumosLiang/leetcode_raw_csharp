public class Solution {
    public int FirstUniqChar(string s)
    {
​
        Dictionary<int, int[]> d = new Dictionary<int, int[]>();
        for (int i = 0; i < s.Length; i++)
        {
            if (d.ContainsKey(s[i])) d[s[i]][1]++;
            else d.Add(s[i], new int[] { i, 1 });
        }
​
        foreach (var item in d)
        {
            if (item.Value[1] == 1) return item.Value[0]; 
        }
​
        return -1;
​
    }
}
