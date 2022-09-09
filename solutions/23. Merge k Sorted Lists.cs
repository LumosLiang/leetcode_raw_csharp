/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public listnode next;
 *     public listnode(int val=0, listnode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
​
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        
​
        
        PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();
        
        foreach(var head in lists)
        {
            if(head != null) pq.Enqueue(head, head.val);
        }
        
        var res = new ListNode();
        var curr = res;
        
        while(pq.Count != 0)
        {
            var node = pq.Dequeue();
            if(node.next != null) pq.Enqueue(node.next, node.next.val);
            
            curr.next = node;
            curr = curr.next;
            // node.next = null;
        }
        
        return res.next;
        
    }
}
​
