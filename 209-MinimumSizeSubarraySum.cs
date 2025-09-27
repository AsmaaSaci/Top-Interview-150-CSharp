public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length, left = 0, sum = 0, minLen = int.MaxValue;
        for (int right = 0; right < n; right++) {
            sum += nums[right];
            while (sum >= target) {
                minLen = Math.Min(minLen, right - left + 1);
                sum -= nums[left++];
            }
        }
        return minLen == int.MaxValue ? 0 : minLen;
    }
}
