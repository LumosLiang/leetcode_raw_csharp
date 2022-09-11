public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
                
//         int length = matrix.Length;
//         PriorityQueue<Tuple<int, int>, int> pq = new PriorityQueue<Tuple<int, int>, int>();
//         pq.Enqueue(new Tuple<int, int>(0, 0), matrix[0][0]);
        
//         HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>
//         {
//             new Tuple<int, int>(0, 0)
//         };
        
//         for(int i = 0; i < k - 1; i++)
//         {
//             var curr = pq.Dequeue();
//             int x = curr.Item1, y = curr.Item2;
            
//             var choice1 = new Tuple<int, int>(x + 1, y);
//             var choice2 = new Tuple<int, int>(x, y + 1);
            
//             if(x + 1 < length && !visited.Contains(choice1))
//             {
//                 pq.Enqueue(choice1, matrix[x + 1][y]);
//                 visited.Add(choice1);
//             }
//             if(y + 1 < length && !visited.Contains(choice2))
//             {   
//                 pq.Enqueue(choice2, matrix[x][y + 1]);
//                 visited.Add(choice2);
//             }
            
//         }
        
//         var res = pq.Peek();
//         return matrix[res.Item1][res.Item2];
        
        int length = matrix.Length;
        var pq = new PriorityQueue<(int row, int col), int>();
        pq.Enqueue((0, 0), matrix[0][0]);
        
        var visited = new HashSet<(int row, int col)>
        {
            (0, 0)
        };
        
        for(int i = 0; i < k - 1; i++)
        {
            (int x, int y) = pq.Dequeue();
            
            var choice1 = (x + 1, y);
            var choice2 = (x, y + 1);
            
            if(x + 1 < length && !visited.Contains(choice1))
            {
                pq.Enqueue(choice1, matrix[x + 1][y]);
                visited.Add(choice1);
            }
            if(y + 1 < length && !visited.Contains(choice2))
            {   
                pq.Enqueue(choice2, matrix[x][y + 1]);
                visited.Add(choice2);
            }
            
        }
        
        (int l1, int l2) = pq.Peek();
        return matrix[l1][l2];
        
    }
}
