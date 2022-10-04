public class Solution {
    public void SetZeroes(int[][] matrix) {
    
        // O(mn), O(0)
        int m = matrix.Length, n = matrix[0].Length;
        bool isColContainZero = false, isRowContainZero = false;
​
        for(int i = 0; i < m; i++)
        {
            if(matrix[i][0] == 0)
            {
                isColContainZero = true;
                break;
            }
        }
        
        for(int i = 0; i < n; i++)
        {
            if(matrix[0][i] == 0)
            {
                isRowContainZero = true;
                break;
            }
        }
                    
    
        for(int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
            {
                if(matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        
        for(int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
            {
                if(matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;                    
                }
            }
        }
              
​
        if(isColContainZero)
        {
            for(int i = 0; i < m; i++)
            {
                matrix[i][0] = 0;
            }
        }
        
        
        if(isRowContainZero)
        {
            for(int i = 0; i < n; i++)
            {
                matrix[0][i] = 0;
            }
        }
​
        
    }
}
