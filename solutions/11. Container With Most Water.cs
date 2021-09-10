public class Solution {
    public int MaxArea(int[] height)
    {
        // [1,8,6,2,5,4,8,3,7]
​
        int left = 0, right = height.Length - 1, res = 0;
​
        while (left <= right)
        {
            res = Math.Max(res, Math.Min(height[left], height[right]) * (right - left));
            if (height[left] <= height[right])
            {
                left++;
            }
            else 
            {
                right--;
            }
        }
​
        return res;
    }
}
