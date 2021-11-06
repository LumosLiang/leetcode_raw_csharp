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
​
​
public class Solution {
    public bool FindTarget(TreeNode root, int k)
    {
        return DFS(root, root, k);
    }
​
    private bool DFS(TreeNode root, TreeNode curr, int k)
    {
        if (curr is null) return false;
​
        return SearchTarget(root, curr, k - curr.val) || DFS(root, curr.left, k) || DFS(root, curr.right, k);
    }
​
    private bool SearchTarget(TreeNode root, TreeNode curr, int val)
    {
        if (root is null) return false;
​
        return val == root.val && root != curr || val > root.val && SearchTarget(root.right, curr, val) || val < root.val && SearchTarget(root.left, curr, val);
    }
}
