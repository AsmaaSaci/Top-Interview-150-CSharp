public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        int n = triangle.Count;
        int[] dp = new int[n];
        for (int i = 0; i < n; i++) dp[i] = triangle[n - 1][i];
        for (int layer = n - 2; layer >= 0; layer--) {
            for (int i = 0; i <= layer; i++) {
                dp[i] = triangle[layer][i] + Math.Min(dp[i], dp[i + 1]);
            }
        }
        return dp[0];
    }
}
