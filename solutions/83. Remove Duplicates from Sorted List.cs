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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head is null) return head;
​
        ListNode curr = head, nxt = head.next;
​
        while (nxt != null)
        {
            if (curr.val == nxt.val)
            {
                nxt = nxt.next;
            }
            else
            {
                curr.next = nxt;
                curr = nxt;
                nxt = curr.next;
            }
​
        }
        curr.next = nxt;
​
        return head;
    }
}
