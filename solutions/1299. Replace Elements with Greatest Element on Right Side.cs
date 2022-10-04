public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        int l = arr.Length;
        var res = new int[l];
        res[l - 1] = -1;
        int curr = -1;
        
        for(int i = l - 2; i >= 0; i--)
        {
            curr = Math.Max(curr, arr[i + 1]);
            res[i] = curr;
        }
        
        return res;
    }
}
