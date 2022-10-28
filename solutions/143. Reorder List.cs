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
public class Solution {
    public void ReorderList(ListNode head) {
        
        if(head == null || head.next == null) return;
        
        ListNode slowPre = null, slow = head, fast = head;
        
        while(fast != null && fast.next != null)
        {
            slowPre = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        
        slowPre.next = null;
        
        ListNode secondHalfHead = Reverse(slow);
        
//         Console.WriteLine(head.val);
//         Console.WriteLine(secondHalfHead.val);
        
        ListNode curr = head, nxt = secondHalfHead;
        
        while(curr != null)
        {
            ListNode temp = curr.next;
            if(nxt == null)
                break;
            curr.next = nxt;
            curr = curr.next;
            nxt = temp;
        }
        
    }
​
​
    public ListNode Reverse(ListNode head)
    {
        if(head == null || head.next == null) return head;
        
        ListNode dummy = new ListNode();
        
        ListNode pre = null, curr = head, nxt = null;
        
        while(curr != null)
        {
            nxt = curr.next;
            curr.next = pre;
            pre = curr;
            curr = nxt;
        }
        
        return pre; 
    }
    
}
