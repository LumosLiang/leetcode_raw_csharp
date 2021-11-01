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
    public bool IsValidBST(TreeNode root)
    {
        return Helper(root, long.MinValue, long.MaxValue);
    }
​
    private bool Helper(TreeNode root, long low, long high)
    {
        if (root is null) return true;
        
        if(root.val < high && root.val > low) return Helper(root.left, low, root.val) && Helper(root.right, root.val, high);
        return false;
​
    }
}
