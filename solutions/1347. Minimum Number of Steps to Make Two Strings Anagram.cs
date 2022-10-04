public class Solution {
    public int MinSteps(string s, string t) {
        
        var res = 0;
        
        Dictionary<int, int> dictS = new Dictionary<int, int>(), dictT = new Dictionary<int, int>();
        
        foreach(var chr in s)
        {
            if(dictS.ContainsKey(chr)) dictS[chr]++;
            else dictS[chr] = 1;
        }
        
        foreach(var chr in t)
        {
            if(dictT.ContainsKey(chr)) dictT[chr]++;
            else dictT[chr] = 1;
        }
        
        foreach (var (key, value) in dictS)
        {
            // Console.WriteLine(((char)key, value));
            if(dictT.ContainsKey(key)) res += value > dictT[key]? Math.Abs(value - dictT[key]):0;
            else res += value;
            // Console.WriteLine(res);
        }
        
        return res;
    }
}
​
​
