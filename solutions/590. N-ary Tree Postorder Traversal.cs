/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;
​
    public Node() {}
​
    public Node(int _val) {
        val = _val;
    }
​
    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/
​
public class Solution {
    public IList<int> Postorder(Node root) {
        REhelper(root).ToList().Reverse();
    
    }
        
    public IList<int> helper(Node root)
    {
        
        var res = new List<int>();
        if (root != null){
            res.Add(root.val);
​
            for(int idx = root.children.Count - 1; idx >= 0 ; idx--)
            {
                res.AddRange(helper(root.children[idx]));
            }
        }
        return res;
     }
}
