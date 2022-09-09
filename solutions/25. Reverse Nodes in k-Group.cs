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
    public ListNode ReverseKGroup(ListNode head, int k) {
        
        if (head is null || head.next is null) return head;
​
        ListNode dummy = new ListNode() {next = head};
        var curr = dummy;
        
        int length = 0;
        while(curr != null)
        {
            curr = curr.next;
            length++;
        }
        length--;
        
        curr = dummy;
        
        for(int i = 0; i < length / k; i++)
        {
            var nxt = curr.next;
            for(int j = 0; j < k - 1; j++)
            {
                var temp = curr.next;
                curr.next = nxt.next;
                nxt.next = nxt.next.next;
                curr.next.next = temp;
            }
            curr = nxt;
        }
        return dummy.next;
    }
}
​
