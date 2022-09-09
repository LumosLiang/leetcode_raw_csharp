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
    public ListNode RotateRight(ListNode head, int k) {
     
        if (head == null) return null;
​
        ListNode curr = head;
        
        int l = 0;
        
        while(curr.next != null)
        {
            curr = curr.next;
            l++;
        }
        
        curr.next = head;
        k = k % (l + 1);
        
        curr = head;
        
        for(int i = 0; i < l - k; i++)
        {
            curr = curr.next;
        }
        
        ListNode newHead = curr.next;
        curr.next = null;
        
        return newHead;
        
        
    }
}
