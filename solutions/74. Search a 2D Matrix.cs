public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var w = matrix.Length;
        var l = matrix[0].Length;
        
        var lo = 0;
        var hi = w * l - 1;
        
        while(lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            if ( == target) return true;
            else if(matrix[mid / l][mid % l] > target) hi = mid - 1; 
            else lo = mid + 1;
        }
        return false;
    }
}
