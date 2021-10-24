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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        
        
        ListNode newhead = new ListNode(0, head);
        
        ListNode slow = newhead, fast = newhead;
        
        int cnt = 0;
        while(cnt < n)
        {
            fast = fast.next;
            cnt++;
        }
        
        while(fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        
        slow.next = slow.next.next;
        
        return newhead.next;
        
    }
}
