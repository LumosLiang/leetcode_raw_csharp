public class Solution {
    public int NextGreaterElement(int n) {
        
        var sb = new StringBuilder(n.ToString());
        //Console.WriteLine(sb);
        
        int p1 = sb.Length - 1, p2 = sb.Length - 2;
        
        while(p2 >= 0 && sb[p2] >= sb[p1])
        {
            p2--;
            p1--;
        }
        
        if(p2 == -1) return -1;
        
        while(p1 < sb.Length && sb[p1] > sb[p2])
            p1++;
​
        Swap(sb, p2, p1 - 1);
        
        p2++;
        p1 = sb.Length - 1;
        while(p2 < p1)
        {
            Swap(sb, p2, p1);
            p2++;
            p1--;
        }
        
        int res = 0, baseNumber = 10;
        foreach(var c in sb.ToString())
        {
            int temp = (c - '0');
            if(res > Int32.MaxValue / baseNumber || res == Int32.MaxValue / baseNumber && temp > 7)
                return - 1;
            res = res * baseNumber + temp;
        }
            
        return res;
        
    }
    
    public void Swap(StringBuilder sb, int i, int j)
    {
        
        if(i < sb.Length && i >= 0 && j < sb.Length && j >= 0)
        {
            var temp = sb[j];
            sb[j] = sb[i];
            sb[i] = temp;
        }
    }
}
​
// 12443322 -> 13443222
    
// 1. find the first smaller
// 2. find the pos where it should belong, exchange,
// 3. reverse rest
