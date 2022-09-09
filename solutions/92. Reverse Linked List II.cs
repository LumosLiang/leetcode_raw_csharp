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
// 头插法
public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        
        
        if (head is null || head.next is null) return head;
​
        ListNode dummy = new ListNode
        {
            next = head
        };
​
        ListNode curr = dummy;
​
        for (int cnt = 0; cnt < left - 1; cnt++)
        {
            curr = curr.next;
        }
​
        var nxt = curr.next;
​
        // insert head
        for (int cnt = 0; cnt < right - left; cnt++)
        {
            var temp = curr.next;
            curr.next = nxt.next;
            nxt.next = nxt.next.next;
            curr.next.next = temp;
        }
​
        return dummy.next;
        
    }
}
​
