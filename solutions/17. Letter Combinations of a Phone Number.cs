public class Solution {
    
    IList<string> res = new List<string>();
    Dictionary<string, string> phone = new Dictionary<string, string>
    {
        { "2", "abc" },
        { "3", "def" },
        { "4", "ghi" },
        { "5", "jkl" },
        { "6", "mno" },
        { "7", "pqrs" },
        { "8", "tuv" },
        { "9", "wxyz" }
    };
    
    public IList<string> LetterCombinations(string digits) {
        if(digits == "") return new List<string>();
        helper(digits, "", digits.Length, 0);
        return res;
    }
    
    public void helper(string choices, string path, int len, int start)
    {
        if(path.Length == len)
        {
            res.Add(path);
            return;
        }
        for(int i = start; i < choices.Length; i++)
        {
            var letters = phone[choices[i].ToString()];
            var tpath = "";
            foreach(var letter in letters)
            {
                tpath = path + letter;
                helper(choices, tpath, len, i + 1);
            }
        }
    }
}
