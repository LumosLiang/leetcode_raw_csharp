/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
​
public class Solution : VersionControl {
    public int FirstBadVersion(int n)
    {
        return Helper(1, n);
    }
​
    private int Helper(int start, int end)
    {
        if (start > end) return -1;
​
        int mid = start + (end - start) / 2;
        if (!IsBadVersion(mid)) return Helper(mid + 1, end);
        else return Helper(start, mid);
    }
​
}
