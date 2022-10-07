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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
    
        return Solution1(preorder, inorder);
    }
    
    public TreeNode Solution1(int[] preorder, int[] inorder) 
    {
        if(preorder.Length == 0) return null;
            
        if(preorder.Length == 1) return new TreeNode(preorder[0]);
        
        int rootVal = preorder[0];
        var res = new TreeNode(rootVal);
        
        int rootIdx = 0;
        for(int i = 0; i < inorder.Length; i++)
        {
            if(inorder[i] == rootVal)
            {
                rootIdx = i;
                break;
            }
        }
        
        // Console.WriteLine(string.Join("", inorder[(rootIdx+1)..]));
        
        res.left = BuildTree(preorder[1..(1 + rootIdx)], inorder[..rootIdx]);
        res.right = BuildTree(preorder[(1 + rootIdx)..], inorder[(rootIdx+1)..]);
        
        return res;
    }
    
    
}
