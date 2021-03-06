public class Solution {
    public int Reverse(int x) {
        int res = 0;
        
        while(x != 0)
        {
            int temp = res * 10 + x % 10;
            if (temp / 10 != res) return 0;
            res = temp;
            x = x / 10;
        }
        return res;
        
    }
}
