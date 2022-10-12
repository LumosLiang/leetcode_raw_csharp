/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) {
        
        if(k == 0) return new List<int>{target.val};
        
        return Sol2(root, target, k);    
    }
    
    public IList<int> Sol2(TreeNode root, TreeNode target, int k)
    {
        var hash = new Dictionary<int, List<int>>();
        Helper(root, hash);
        if(hash.Count == 0) return new List<int>{};
        
        var q = new Queue<int>();
        var visited = new HashSet<int>();
        q.Enqueue(target.val);
        visited.Add(target.val);
            
        while(q.Count != 0)
        {
            var temp = new Queue<int>();
            while(q.Count != 0)
            {
                var curr = q.Dequeue();
                foreach(var item in hash[curr])
                {
                    if(!visited.Contains(item))
                    {
                        temp.Enqueue(item);
                        visited.Add(item);
                    }
                }
            }
            k--;
            if(k == 0)
                return new List<int>(temp.ToArray());
            q = temp;
        }
        
        return new List<int>{};
    }
    
    public void Helper(TreeNode root, Dictionary<int, List<int>> hash)
    {
        if(root == null) return;
        
        if(root.left != null)
        {
            if(hash.ContainsKey(root.val))
                hash[root.val].Add(root.left.val);
            else
                hash[root.val] = new List<int>{root.left.val};
            
            if(hash.ContainsKey(root.left.val))
                hash[root.left.val].Add(root.val);
            else
                hash[root.left.val] = new List<int>{root.val};
        }
            
