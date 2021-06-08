public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        var max = candies.Max();
        return candies.Select(c => c + extraCandies >= max).ToList();
        
    }
}
