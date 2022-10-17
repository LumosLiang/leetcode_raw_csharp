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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
     
        return InsertIntoBST1(root, val);
    }
​
    public TreeNode InsertIntoBST1(TreeNode root, int val)
    {
        // base
        if (root is null) return new TreeNode(val);
​
        TreeNode pre = null, curr = root;
        
        while(curr != null)
        {
            pre = curr;
            if(curr.val > val)
                curr = curr.left;
            else
                curr = curr.right;
        }
        if(pre.val > val)
            pre.left = new TreeNode(val);
        else
            pre.right = new TreeNode(val);
        
        return root;
        
    }
    
    
    public TreeNode InsertIntoBST2(TreeNode root, int val)
    {
        // base
        if (root is null) return new TreeNode(val);
​
        // operation
        if (root.val < val) root.right = InsertIntoBST(root.right, val);
      
        else root.left = InsertIntoBST(root.left, val);
      
        return root;
    }
    
}
​
