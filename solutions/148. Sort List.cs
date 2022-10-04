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
