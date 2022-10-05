public class Solution {
    public int MyAtoi(string s) {
        
        int p = 0;
        int length = s.Length;
        
        if(p == length) return 0;
        
        int sign = 1;
        
        while(p < length && s[p] == ' ') p++;
        
        if(p == length) return 0;
        
        if(s[p] == '-') 
        {
            sign = -1;
            p++;
        }
        else if(s[p] == '+')
        {
            p++;
        }
        
        int res = 0, baseTen = 10;
​
        while(p < length && s[p] <= '9' && s[p] >= '0')
        {
            int temp = res, digit = s[p] - '0';
            
            if(temp > Int32.MaxValue / baseTen || (temp == Int32.MaxValue / baseTen && digit > 7))
            {
                if(sign == 1) return Int32.MaxValue;
                else return Int32.MinValue;
            }
            
            res = temp * baseTen + digit;
            
            p++;
        }
        
        return res * sign;
    }
}
