public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        
        var res = new List<string>();
        Helper(n, n, "", res); 
        return res;
    }
    
    public void Helper(int left, int right, string path, List<string> res)
    {
        if(left == 0 && right == 0)
        {
            res.Add(path);
            return;
        }
        
        if(right < left || left < 0 || right < 0)  return;
        
        Helper(left - 1, right, path + "(", res);
        Helper(left, right - 1, path + ")", res);
    }
    
}
​
​
​
​
​
​
// 3:
//                (
             
//              (    )
        
//          (    )       (
    
//        )    (    )   (   )
