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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        
        if(root1 is null && root2 is null) return null;
        if(root1 != null && root2 is null) return root1;
        if(root1 is null && root2 != null) return root2;
            
        TreeNode newroot = new TreeNode(root1.val + root2.val);
            
        newroot.left = MergeTrees(root1.left, root2.left);
        newroot.right = MergeTrees(root1.right, root2.right);
        
        return newroot;
        
    }
}
