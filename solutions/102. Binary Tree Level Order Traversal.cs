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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> res = new List<IList<int>>();
        if (root is null) return res;
​
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
​
        while (q.Count != 0)
        {
            Queue<TreeNode> tempnode = new Queue<TreeNode>();
            IList<int> tempval = new List<int>();
​
            while (q.Count != 0)
            {
                var node = q.Dequeue();
                tempval.Add(node.val);
                if (node.left != null) tempnode.Enqueue(node.left);
                if (node.right != null) tempnode.Enqueue(node.right);
            }
            q = tempnode;
            res.Add(tempval);
        }
​
        return res;
    }
}
