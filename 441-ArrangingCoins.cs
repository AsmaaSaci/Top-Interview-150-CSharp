public class Solution {
    public int ArrangeCoins(int n) {
        long left = 1, right = n;
        while (left <= right) {
            long mid = left + (right - left) / 2;
            long coins = mid * (mid + 1) / 2;
            if (coins == n) return (int)mid;
            if (coins < n) left = mid + 1;
            else right = mid - 1;
        }
        return (int)right;
    }
}
