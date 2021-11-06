public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        int res = 0, curr = x;
        while (curr != 0)
        {
            res = res * 10 + curr % 10;
            curr = curr / 10;
        }
​
        return res == x;
    }
}
