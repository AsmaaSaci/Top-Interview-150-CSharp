public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if (n == 0) return 0;
        if (n == 1) return nums[0];
        int a = nums[0], b = Math.Max(nums[0], nums[1]);
        for (int i = 2; i < n; i++) {
            int temp = Math.Max(b, a + nums[i]);
            a = b;
            b = temp;
        }
        return b;
    }
}
