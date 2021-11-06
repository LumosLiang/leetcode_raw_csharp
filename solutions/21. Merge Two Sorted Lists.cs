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
​
    public ListNode MergeTwoLists(ListNode A, ListNode B)
    {
        if (A == null) return B;
        if (B == null) return A;
​
        if (A.val < B.val)
        {
            A.next = MergeTwoLists(A.next, B);
            return A;
        }
        else
        {
            B.next = MergeTwoLists(B.next, A);
            return B;
        }
    }
}
​
​
// public class Solution {
​
//     public ListNode MergeTwoLists(ListNode A, ListNode B)
//     {
//         if (A == null) return B;
//         if (B == null) return A;
​
//         ListNode dummy = new ListNode(0);
//         ListNode currA = A, currB = B, curr = dummy;
​
//         while (currA != null && currB != null)
//         {
//             if (currA.val <= currB.val)
//             {
//                 curr.next = new ListNode(currA.val);
//                 currA = currA.next;
//             }
//             else 
//             {
//                 curr.next = new ListNode(currB.val);
//                 currB = currB.next;
//             }
//             curr = curr.next;
//         }
​
//         if (currA != null) curr.next = currA;
//         else curr.next = currB;
​
//         return dummy.next;
//     }
// }
