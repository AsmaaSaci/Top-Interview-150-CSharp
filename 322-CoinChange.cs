public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int max = amount + 1;
        int[] dp = new int[amount + 1];
        for (int i = 1; i <= amount; i++) dp[i] = max;
        for (int i = 1; i <= amount; i++) {
            foreach (int c in coins) {
                if (i - c >= 0) dp[i] = Math.Min(dp[i], dp[i - c] + 1);
            }
        }
        return dp[amount] > amount ? -1 : dp[amount];
    }
}
