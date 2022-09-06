public class Solution {
    public int Search(int[] nums, int target)
    {
​
        var l = 0;
        var r = nums.Length - 1;
​
        while (l < r)
        {
            var mid = l + (r - l) / 2;
            if (nums[mid] == target) return mid;
​
            if (nums[mid] > nums[r] && target <= nums[r]) l = mid + 1;
            else if (target > nums[r] && nums[mid] <= nums[r]) r = mid - 1;
            else
            {
                if (nums[mid] < target) l = mid + 1;
                else r = mid;
            }
​
        }
        if (nums[l] == target) return l;
        else return -1;
    }
}
