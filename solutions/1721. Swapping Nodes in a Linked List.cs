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
    public ListNode SwapNodes(ListNode head, int k) {
    
        int count = 1;
        var fast = head;
        while(count < k)
        {
            fast = fast.next;
            count++;
        }
        var begin = fast;
        var slow = head;
        while(fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
        var end = slow;
        
        int tempval = begin.val;
        begin.val = end.val;
        end.val = tempval;
        
        return head;
        
    }
}
