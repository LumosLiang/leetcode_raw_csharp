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
    public TreeNode DeleteNode(TreeNode root, int key) {
        return Balanced(root, key);
    }
    public TreeNode UnBalanced(TreeNode root, int key)
    {
        if(root == null) return null;
        
        if(root.val > key)
            root.left = UnBalanced(root.left, key);
        
        else if(root.val < key)
            root.right = UnBalanced(root.right, key);
        
        else
        {
            if(root.left == null) return root.right;
        
            if(root.right == null) return root.left;
            
            TreeNode curr = root.left, pre = null;
            
            while(curr != null)
            {
                pre = curr;
                curr = curr.right;
            }
            pre.right = root.right;
            
            return root.left;
        }
        return root;
    }
    
    public TreeNode Balanced(TreeNode root, int key)
    {
        if(root == null) return null;
        
        if(root.val > key)
            root.left = Balanced(root.left, key);
        
        else if(root.val < key)
            root.right = Balanced(root.right, key);
        
        else
        {
            if(root.left == null) return root.right;
            if(root.right == null) return root.left;
            
            TreeNode curr = root.left, pre = null;
            
            while(curr != null)
            {
                pre = curr;
                curr = curr.right;
            }
            
            root.val = pre.val;
            root.left = Balanced(root.left, pre.val);
        }
        return root;
    }
}
