public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
       
        List<int> indegree = new List<int>(new int[numCourses]);
        Dictionary<int, List<int>> neighbors = new Dictionary<int, List<int>>();
​
        foreach (var prerequisite in prerequisites)
        {
            var nxt = prerequisite[0];
            var pre = prerequisite[1];
​
            indegree[nxt]++;
            if (neighbors.ContainsKey(pre))
            {
                neighbors[pre].Add(nxt);
            }
            else
            {
                neighbors[pre] = new List<int> { nxt };
            }
​
        }
​
        Queue<int> q = new Queue<int>();
        for (int i = 0; i < indegree.Count; i++)
        {
            if (indegree[i] == 0) q.Enqueue(i);
        }
​
        List<int> res = new List<int>();
        int count = q.Count;
        
        while (q.Count > 0)
        {
            var currCourse = q.Dequeue();
            res.Add(currCourse);
            if (neighbors.ContainsKey(currCourse)) { 
                foreach (var neighbor in neighbors[currCourse])
                {
                    indegree[neighbor]--;
                    if (indegree[neighbor] == 0)
                    {
                        q.Enqueue(neighbor);
                        count++;
                    }
                }
            }
        }
    
        if(count == numCourses) return res.ToArray();
        else return new int[]{};
 
    }
}
​
