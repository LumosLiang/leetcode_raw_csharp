/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;
​
    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }
​
    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }
​
    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/
​
public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null) return null;
        
        var hash = new Dictionary<Node, Node>()
        {
            {node, new Node(node.val)}
        };
        
        // BFS
        
        var q = new Queue<Node>();
        q.Enqueue(node);
        
        while(q.Count != 0)
        {
            var currNode = q.Dequeue();
            
            foreach(var ngbNode in currNode.neighbors)
            {
                if(!hash.ContainsKey(ngbNode))
                {
                    hash.Add(ngbNode, new Node(ngbNode.val));
                    q.Enqueue(ngbNode);
                }
                hash[currNode].neighbors.Add(hash[ngbNode]);
            }
        }
        
        // Console.WriteLine(hash);
        
        // BFS2
        
//         q.Enqueue(node);
//         var secdVisited = new HashSet<Node>(){node};
        
//         while(q.Count != 0)
//         {
//             var currNode = q.Dequeue();
            
//             foreach(var ngbNode in currNode.neighbors)
//             {
//                 hash[currNode].neighbors.Add(hash[ngbNode]);
//                 if(!secdVisited.Contains(ngbNode))
//                 {
//                     q.Enqueue(ngbNode);
//                     secdVisited.Add(ngbNode);
