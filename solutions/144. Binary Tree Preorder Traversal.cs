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
    public IList<int> PreorderTraversal(TreeNode root) {
        var res = new List<int>();
        if(root == null)
        {
            return res;
        }
        res.Add(root.val);
        return res.Concat(PreorderTraversal(root.left)).Concat(PreorderTraversal(root.right)).ToList();
   
    }
}
