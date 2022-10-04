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
            var temp = value;
            if(dictT.ContainsKey(key)) 
            {
                if(dictT[key] <= temp)
                {
                    temp -= dictT[key];
                    dictT.Remove(key);
                }
                else
                {
                    dictT[key] -= temp;
                    temp = 0;
                }
            }
            res += temp;
            // Console.WriteLine(res);
        }
        
        return res + dictT.Values.Sum();
​
    }
}
