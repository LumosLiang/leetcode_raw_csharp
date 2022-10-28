/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
​
​
//dummy -> 1 -> 2 -> 3 -> 4
    
​
​
public class Solution {
    public ListNode SwapPairs(ListNode head) 
    {
        if(head == null || head.next == null) return head;
        
        ListNode dummy = new ListNode();
        dummy.next = head;
        
        ListNode curr = dummy;
        
        // insert-head
        while(curr != null)
        {
            ListNode tail = curr.next;
            
            if(tail == null || tail.next == null) break;
            
            curr.next = tail.next;
            tail.next = tail.next.next;
            curr.next.next = tail;
            
            curr = tail;
        }
        
        return dummy.next;  
    }  
        
    public ListNode Helper(ListNode head)
    {
        if(head == null || head.next == null) return head;
        
        ListNode newHead = head.next;
        
        head.next = head.next.next;
        newHead.next = head;
        
        head.next = Helper(head.next);
        
        return newHead;
        
    }
​
}
