public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
    
        if(k < 1) return 0;
        
        var graph = new Dictionary<int, Dictionary<int, int>>();
        
        foreach(var item in times)
        {
            int src = item[0], dest = item[1], time = item[2];
            if(!graph.ContainsKey(src))
            {
                graph[src] = new Dictionary<int, int>();
            }
            graph[src].Add(dest, time);
        }
        
        var pq = new PriorityQueue<(int time, int node), int>();
        var timePass = new Dictionary<int, int>();
        pq.Enqueue((0, k), 0);
        
        while(pq.Count != 0)
        {
            (int currTime, int currNode) = pq.Dequeue();
            
            if(timePass.ContainsKey(currNode)) continue;
            
            timePass.Add(currNode, currTime);
            
            if(!graph.ContainsKey(currNode)) continue;
            foreach((int target, int time) in graph[currNode])
            {
                pq.Enqueue((currTime + time, target), currTime + time);
            }
        }
        var res = timePass.Count == n? timePass.Values.Max():-1;
        
        return res;
        
    }
}
