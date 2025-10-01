public class Solution {
    public bool IsPerfectSquare(int num) {
        long left = 1, right = num;
        while (left <= right) {
            long mid = left + (right - left) / 2;
            long sq = mid * mid;
            if (sq == num) return true;
            if (sq < num) left = mid + 1;
            else right = mid - 1;
        }
        return false;
    }
}
