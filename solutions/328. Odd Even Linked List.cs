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
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        
        if(head is null || head.next is null) return head;
        
        ListNode odd = head, even = head.next;
        ListNode currEven = even;
        
        while(currEven != null && currEven.next != null)
        {
            odd.next = odd.next.next;
            odd = odd.next;
            currEven.next = currEven.next.next;
            currEven = currEven.next;
        }
        
        odd.next = even;
        
        return head;
        
    }
}
