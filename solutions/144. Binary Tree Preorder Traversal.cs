/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversalDFS(TreeNode root)
    {
        List<int> res = new List<int>();
        if (root is null) return res;
​
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);
​
        while (s.Count != 0)
        {
            var temp = s.Pop();
            if (temp != null)
            {
                res.Add(temp.val);
                s.Push(temp.right);
                s.Push(temp.left);
            }
        }
        return res;
    }
​
    public IList<int> PreorderTraversalDFS2(TreeNode root)
    {
        List<int> res = new List<int>();
        DFS(root, res);
        return res;
    }
​
    private void DFS(TreeNode root, List<int> list)
    {
        if (root is null) return;
​
