public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        return Sol2(matrix);
    }    
    
    public IList<int> Sol1(int[][] matrix)
    {
        IList<int> res = new List<int>();
        
        int m = matrix.Length, n = matrix[0].Length;
        
        int left = 0, right = n, up = 0, down = m; 
        
        
        while(true)
        {
            for(int i = left; i < right; i++)
            {
                res.Add(matrix[up][i]);
            }
            
            up++;
            
            if(up >= down) break;
            
            for(int i = up; i < down; i++)
            {
                res.Add(matrix[i][right - 1]);
            }
            
            right--;
            if(right <= left) break;
            
            for(int i = right - 1; i >= left; i--)
            {
                res.Add(matrix[down - 1][i]);
            }
            
            down--;
            if(down <= up) break;
            
            for(int i = down - 1; i >= up; i--)
            {
                res.Add(matrix[i][left]);
            }
            
            left++;
            if(left >= right) break;
        }
        
        return res;
    }   
    
​
    public IList<int> Sol2(int[][] matrix)
    {
        
        IList<int> res = new List<int>();
        var s = new HashSet<(int x, int y)>();
        
        int m = matrix.Length, n = matrix[0].Length;
        int x = 0, y = 0, dx = 0, dy = 1;
        int cnt = 0;
        
        while(cnt < m * n)
        {
            if(x + dx < 0 || x + dx >= m || y + dy < 0 || y + dy >= n || s.Contains((x + dx, y + dy)))
            {
                var temp = dy;
                dy = -dx;
                dx = temp;
            }
            
            res.Add(matrix[x][y]);
            s.Add((x, y));
            x += dx;
            y += dy;
            cnt++;
        }
        
        return res;
        
    }
    
}
​
​
