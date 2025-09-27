public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int total = 0, maxSum = nums[0], curMax = 0, minSum = nums[0], curMin = 0;
        foreach (int n in nums) {
            curMax = Math.Max(curMax + n, n);
            maxSum = Math.Max(maxSum, curMax);
            curMin = Math.Min(curMin + n, n);
            minSum = Math.Min(minSum, curMin);
            total += n;
        }
        return maxSum > 0 ? Math.Max(maxSum, total - minSum) : maxSum;
    }
}
