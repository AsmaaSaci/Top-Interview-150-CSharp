public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int m = matrix.Length;
        if (m == 0) return 0;
        int n = matrix[0].Length;
        int[,] dp = new int[m + 1, n + 1];
        int max = 0;
        for (int i = 1; i <= m; i++) {
            for (int j = 1; j <= n; j++) {
                if (matrix[i - 1][j - 1] == '1') {
                    dp[i, j] = Math.Min(dp[i - 1, j], Math.Min(dp[i, j - 1], dp[i - 1, j - 1])) + 1;
                    max = Math.Max(max, dp[i, j]);
                }
            }
        }
        return max * max;
    }
}
