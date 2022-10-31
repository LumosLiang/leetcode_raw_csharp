        next = null;
        random = null;
    }
}
*/
​
public class Solution {
    public Node CopyRandomList(Node head) {
        return Sol2(head);
    }
    
    // O(N), O(N)
    public Node Sol1(Node head)
    {
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
    
    // O(N), O(1)
    public Node Sol2(Node head)
    {
        if(head == null) return null;
        
        Node curr = head;
        
        while(curr != null)
        {
            Node nxt = curr.next;
            curr.next = new Node(curr.val);
            curr.next.next = nxt;
            curr = nxt;
        }
        
        Node curr0 = head;
        while(curr0 != null)
        {
            if(curr0.random != null) curr0.next.random = curr0.random.next;
