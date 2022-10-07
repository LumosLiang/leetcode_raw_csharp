public class Codec 
{
​
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) 
    {
        var result = new List<string>();
​
        if (root == null) return "";
​
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
​
        while(queue.Any())
        {
            var size = queue.Count;
​
            for (int s = 0; s < size; s++)
            {
                var cur = queue.Dequeue();
​
                if (cur == null) 
                {
                    result.Add("n");
                    continue;
                }
                else             result.Add($"{cur.val}");
​
                queue.Enqueue(cur.left);
                queue.Enqueue(cur.right);
            }
        }
    
        //Console.WriteLine(string.Join(",", result));
        return string.Join(",", result);
    }
​
    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) 
    {
        if (data == "") return null;
​
        var nodes = data.Split(',');
​
        var root = new TreeNode(int.Parse(nodes[0]));
​
        int i = 1;
​
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
​
        while(i < nodes.Length)
        {
            var cur = queue.Dequeue();
            if (nodes[i] != "n")
            {
                cur.left = new TreeNode(int.Parse(nodes[i]));
                queue.Enqueue(cur.left);
            }
​
            i++;
​
            if (nodes[i] != "n")
            {
                cur.right = new TreeNode(int.Parse(nodes[i]));
                queue.Enqueue(cur.right);
            }
            
            i++;
        }
​
        return root;
    }
}
