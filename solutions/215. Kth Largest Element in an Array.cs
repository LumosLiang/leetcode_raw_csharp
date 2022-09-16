public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        int l = 0, r = nums.Length - 1;
        Helper(nums, l, r, k);
        return nums[^k];
    }
    
    public void Helper(int[] nums, int left, int right, int k)
    {
        if(left >= right) return;
        
        int mid = left + (right - left) / 2;
        var pivot = nums[mid];
        
        Swap(nums, left, mid);
        
        int p1 = left + 1;
        for(int p2 = left + 1; p2 <= right; p2++)
        {
            if(nums[p2] < pivot)
            {
                Swap(nums, p1, p2);
                p1++;
            }
        }
        
        Swap(nums, p1 - 1, left);
        
        if(right + 1 - (p1 - 1) == k) return;
        else if(right + 1 - (p1 - 1) > k) Helper(nums, p1, right, k);
        else Helper(nums, left, p1 - 2, k - (right + 1 - (p1 - 1)));
    }
    
    private void Swap(int[] nums, int p1, int p2)
    {
        if(p1 >= 0 && p1 < nums.Length && p2 >= 0 && p2 < nums.Length) 
        {
            var temp = nums[p2];
            nums[p2] = nums[p1];
            nums[p1] = temp;
        }
    }
    
    
    public int FindKthLargest2(int[] nums, int k) {
    
        
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        
        foreach(int num in nums)
        {
            if(pq.Count < k)
                pq.Enqueue(num, num);
            else
            {
                pq.EnqueueDequeue(num, num);
            }
        }
        
        return pq.Peek();
        
    }
    
}
