public class Solution {
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        BackTrackPermute(new List<int>(nums), new List<int>(), res);
        return res;
    }
​
    private void BackTrackPermute(List<int> choices, List<int> path, IList<IList<int>> result)
    {
        if (choices.Count == 0)
        {
            result.Add(new List<int>(path));
            return;
        }
​
        for (int i = 0; i < choices.Count; i++)
        {
            path.Add(choices[i]);
            var tchoices = choices.GetRange(0, i);
            tchoices.AddRange(choices.GetRange(i + 1, choices.Count - i - 1));
            BackTrackPermute(tchoices, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}
