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
    public bool IsSymmetric(TreeNode root)
    {
​
        return helper(root.left, root.right);
​
    }
​
    private bool helper(TreeNode left, TreeNode right)
    {
        if (left is null && right is null) return true;
​
        if (left is null || right is null) return false;
​
        if (left.val != right.val) return false;
​
        return helper(left.left, right.right) && helper(left.right, right.left);
​
    }
}
