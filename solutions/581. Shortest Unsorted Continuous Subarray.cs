public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        
        int length = nums.Length;
        
        int left = length - 1, right = 0;
        
        Stack<int> leftMonoStack = new Stack<int>(), rightMonoStack = new Stack<int>();
        
        for(int i = 0; i < length; i++)
        {
            while(leftMonoStack.Count != 0 && nums[leftMonoStack.Peek()] > nums[i])
            {
                left = Math.Min(left, leftMonoStack.Pop());
            }
            leftMonoStack.Push(i);
        }
        
        for(int i = length - 1; i > -1; i--)
        {
            while(rightMonoStack.Count != 0 && nums[rightMonoStack.Peek()] < nums[i])
            {
                right = Math.Max(right, rightMonoStack.Pop());
            }
            rightMonoStack.Push(i);
        }
        
        return right > left? right - left + 1:0;
    }
}
​
