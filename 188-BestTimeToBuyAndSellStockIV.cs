public class Solution {
    public int MaxProfit(int k, int[] prices) {
        int n = prices.Length;
        if (n == 0) return 0;
        if (k >= n / 2) {
            int profit = 0;
            for (int i = 1; i < n; i++) {
                if (prices[i] > prices[i - 1]) profit += prices[i] - prices[i - 1];
            }
            return profit;
        }
        int[] buy = new int[k + 1];
        int[] sell = new int[k + 1];
        for (int i = 0; i <= k; i++) buy[i] = int.MinValue;
        foreach (int price in prices) {
            for (int j = 1; j <= k; j++) {
                buy[j] = Math.Max(buy[j], sell[j - 1] - price);
                sell[j] = Math.Max(sell[j], buy[j] + price);
            }
        }
        return sell[k];
    }
}
