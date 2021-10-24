public class Solution {
    public bool CanConstruct(string ransomNote, string magazine)
    {
​
        Dictionary<int, int> criteria = new Dictionary<int, int>(), temp = new Dictionary<int, int>();
        int cnt = 0;
​
        foreach (char c in magazine)
        {
            if (criteria.ContainsKey(c)) criteria[c]++;
            else criteria.Add(c, 1);
        }
​
        foreach (char c in ransomNote)
        {
            if (temp.ContainsKey(c)) temp[c]++;
            else temp.Add(c, 1);
        }
​
        foreach (var item in temp)
        {
            if (criteria.ContainsKey(item.Key) && criteria[item.Key] >= item.Value) cnt++;
        }
​
        if (cnt == temp.Count) return true;
        else return false;
    }
}
