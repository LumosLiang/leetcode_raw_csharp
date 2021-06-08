public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var res = new List<IList<int>>();
        
        void backtrack(int[] choices, List<int> path)
        {
            if(choices.Length == 0)
            {
                res.Add(new List<int>(path));
                return;
            }
            for(int i = 0; i < choices.Length; i++)
            {
                path.Add(choices[i]);
                ArraySegment<int> c1 = new ArraySegment<int>( choices, 0, i);
                ArraySegment<int> c2 = new ArraySegment<int>( choices, i + 1, choices.Length - i - 1);
                choices = c1.ToArray().Concat(c2.ToArray()).ToArray();
                backtrack(choices, path);
            }
            
        }
        var p= new List<int>();
        backtrack(nums, p);
        return res;
    }
}
​
​
        
