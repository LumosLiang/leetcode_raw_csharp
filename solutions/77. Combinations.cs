public class Solution {
    
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> res = new List<IList<int>>();
​
        BackTrackCombine(n, new List<int>(), res, k, 1);
        return res;
    }
​
    private void BackTrackCombine(int choices, List<int> path, IList<IList<int>> result, int length, int start)
    {
        if (path.Count == length)
        {
            result.Add(new List<int>(path));
            return;
        }
​
        for (int i = start; i <= choices; i++)
        {
            path.Add(i);
            BackTrackCombine(choices, path, result, length, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}
​
​
