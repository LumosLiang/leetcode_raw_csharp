public class Solution {
    public IList<string> LetterCasePermutation(string s)
    {
        IList<string> res = new List<string>();
        BackTrackLCP(0, s, "", res);
        return res;
    }
​
    private void BackTrackLCP(int idx, string s, string path, IList<string> res)
    {
​
        if (idx == s.Length)
        {
            res.Add(path);
            return;
        }
​
        var c = s[idx];
        if (char.IsLetter(c))
        {
            BackTrackLCP(idx + 1, s, path + char.ToUpper(c).ToString(), res);
            BackTrackLCP(idx + 1, s, path + char.ToLower(c).ToString(), res);
        }
        else
        {
            BackTrackLCP(idx + 1, s, path + c.ToString(), res);
        }
    }
}
