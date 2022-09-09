/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/
​
public class Solution {
    public Node CopyRandomList(Node head) {
     
        if(head is null) return null;
        
        Dictionary<Node, Node> hash = new Dictionary<Node, Node>();
        
        Node curr = head;
        
        while(curr != null)
        {
            hash[curr] = new Node(curr.val);
            curr = curr.next;
        }
        
        foreach(var item in hash)
        {
            Node k = item.Key, v = item.Value;
            if(k.next != null) v.next = hash[k.next];
            if(k.random != null) v.random = hash[k.random];
        }
        
        return hash[head];
    }
}
