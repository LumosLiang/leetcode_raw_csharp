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
    public ListNode DeleteDuplicates(ListNode head) {
        
        if(head is null || head.next is null) return head;
        
        ListNode dummy = new ListNode(-101);
        dummy.next = head;
        
        ListNode pre = dummy, curr = head, nxt = null;
        
        while(curr != null)
        {
            nxt = curr.next;
            if(nxt != null && curr.val != nxt.val || nxt == null)
            {
                pre.next = curr;
                pre = curr;
            }
            else
            {
                while(nxt != null && curr.val == nxt.val)
                {
                    curr = nxt;
                    nxt = curr.next;
                }
            }
            curr = nxt;
        }
        
        pre.next = curr;
        
        return dummy.next;
    }
}
