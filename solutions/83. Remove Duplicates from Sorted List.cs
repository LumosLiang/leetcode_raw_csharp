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
        if (head is null || head.next is null) return head;
​
        ListNode curr = head, nxt = null;
​
//         while (nxt != null)
//         {
//             if (curr.val != nxt.val)  
//             {
//                 curr.next = nxt;
//                 curr = curr.next;
//             }
​
//             nxt = nxt.next;
//         }
//         curr.next = nxt;
        
        while(curr != null)
        {
            nxt = curr.next;
            while(nxt != null && nxt.val == curr.val)
                nxt = nxt.next;
            curr.next = nxt;
            curr = curr.next;
        }
​
        return head;
    }
}
​
​
