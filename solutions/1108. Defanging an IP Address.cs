​
public class Solution {
    public string DefangIPaddr(string address) {
        
        var res = new StringBuilder();
        
        foreach(var a in address)
        {
            if(a == '.')
            {
                res.Append("[.]");
            }
            else
            {
                res.Append(a);
            }
        }
        
        return res.ToString();
    }
}
