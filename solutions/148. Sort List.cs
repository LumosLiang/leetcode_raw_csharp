/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode SortList(ListNode head) {
        
        if(head == null || head.next == null)
            return head;
        
        // return MergeSort(head);
        return QuickSort(head);
        
    }
    
    public ListNode MergeSort(ListNode head)
    {
        // base
        if(head == null || head.next == null) return head;
        
        // find mid
        ListNode slow = head, fast = head;
        ListNode leftHead = head, rightHead = null, slowPre = null;
        while(fast != null && fast.next != null)
        {
            slowPre = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        
        slowPre.next = null;
        rightHead = slow;
        
        var left = MergeSort(leftHead);
        var right = MergeSort(rightHead);
        
        return Merge(left, right);
    }
    
    public ListNode Merge(ListNode headA, ListNode headB)
    {
        if(headA is null) return headB;
        if(headB is null) return headA;
        
        ListNode dummy = new ListNode();
        ListNode currA = headA, currB = headB, curr = dummy;
        
        while(currA != null && currB != null)
        {
            if(currA.val >= currB.val)
            {
                curr.next = currB;
                currB = currB.next;
            }
            else
            {
                curr.next = currA;
                currA = currA.next;
            }
            curr = curr.next;
        }
        
        curr.next = currA == null? currB:currA;
        
        return dummy.next;
    }
        
    public ListNode QuickSort(ListNode head)
    {
        // base
        if(head == null || head.next == null) return head;
        
        // find pivot
        int pivotVal = head.val;
        
        // move against pivot
        var curr = head;
        ListNode left = new ListNode(), mid = new ListNode(), right = new ListNode();
        ListNode currLeft = left, currMid = mid, currRight = right;
        
        while(curr != null)
        {
            if(curr.val < pivotVal)
            {
                currLeft.next = curr;
                currLeft = currLeft.next;
            }
            else if(curr.val > pivotVal)
            {
                currRight.next = curr;
                currRight = currRight.next;
            }
            else
            {
                currMid.next = curr;
                currMid = currMid.next;                
            }
            curr = curr.next;
        }
        
        currLeft.next = null;
        currMid.next = null;
        currRight.next = null;
        
        // quick
        
        var leftHead = QuickSort(left.next);
        var rightHead = QuickSort(right.next);
        
        // compose
        
        currMid.next = rightHead;
        
        if(leftHead == null) return mid.next;
        var newCurr = leftHead;
        while(newCurr.next != null) newCurr = newCurr.next;
        newCurr.next = mid.next;
        return leftHead;
    }
}
