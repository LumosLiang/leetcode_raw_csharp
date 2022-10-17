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
    public bool IsBalanced(TreeNode root) {
     
        // return Sol1(root);
        (bool isbalan, int height) = Sol2(root);
        return isbalan;
    }
    
    public (bool isBalanced, int height) Sol2(TreeNode root)
    {
        if(root == null) return (true, 0);
        
        (bool isLeftBalanced, int left) =  Sol2(root.left);
        (bool isRightBalanced, int right) =  Sol2(root.right);
        
        if(isLeftBalanced && isRightBalanced)
        {
            if(Math.Abs(left - right) > 1) return (false, 0);
            return (true, 1 + Math.Max(left, right));
        }
        
        return (false, 0);
    }
    
    public bool Sol1(TreeNode root)
    {
        if(root == null) return true;
        
        int left = GetHeight(root.left);
        int right = GetHeight(root.right);
        
        if(Math.Abs(left - right) > 1) return false;
        
        return IsBalanced(root.left) && IsBalanced(root.right);
    }
    
    public int GetHeight(TreeNode root)
    {
        if(root == null) return 0;
        
        return 1 + Math.Max(GetHeight(root.left), GetHeight(root.right));
    }
}
