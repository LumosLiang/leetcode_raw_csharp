public class Solution {
    public int[][] UpdateMatrix(int[][] mat)
    {
        int m = mat.Length, n = mat[0].Length;
        int[] DIR = new int[] { 0, 1, 0, -1, 0 };
​
        Queue<int[]> q = new Queue<int[]>();
​
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 0) q.Enqueue(new int[] { i, j });
                else mat[i][j] = -1;
            }
        }
​
        while (q.Count != 0)
        {
            var item = q.Dequeue();
            int r = item[0], c = item[1];
            for (int k = 0; k < 4; k++)
            {
                int nr = r + DIR[k], nc = c + DIR[k + 1];
                if (nr < 0 || nr >= m || nc < 0 || nc >= n || mat[nr][nc] != -1) continue;
                mat[nr][nc] = mat[r][c] + 1;
                q.Enqueue(new int[] { nr, nc });
            }
        }
​
        return mat; 
    }
​
}
