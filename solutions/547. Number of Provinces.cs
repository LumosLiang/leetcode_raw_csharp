public class UnionFind
{
    public int[] root;
    public int[] rank;
    private int size;
    
    public UnionFind(int size)
    {
        this.size = size;
        root = new int[size]; 
        rank = new int[size]; 
        
        for(int i = 0; i < root.Length; i++)
        {
            root[i] = i; 
            rank[i] = 0;
        }
    }
    
    public void Union(int x, int y)
    {
        var rootX = Find(x);
        var rootY = Find(y);
        if(rootX != rootY)
        {
            if(rank[rootX] > rank[rootY])
                root[rootY] = rootX;
            else if(rank[rootX] < rank[rootY])
                root[rootX] = rootY;
            else
            {
                root[rootY] = rootX;
                rank[rootX]++;
            }
            size--;
        }
    }
        
    public int Find(int target)
    {
        if(target == root[target]) return root[target];
        root[target] = Find(root[target]);
        return root[target];
    }
    
    public int GetSize()
    {
        return size;
    }
}
​
public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        
        int m = isConnected.Length;
        
        var uf = new UnionFind(m);
        Console.WriteLine(uf.GetSize());
        
        for(int i = 0; i < m; i++)
        {
            for(int j = i + 1; j < m; j++)
            {
                if(isConnected[i][j] == 1)
                    uf.Union(i, j);
            }
        }
        
        return uf.GetSize();
    }
}
