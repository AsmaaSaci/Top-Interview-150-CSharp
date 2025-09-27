public class Solution {
    public int Trap(int[] height) {
        int n = height.Length, left = 0, right = n - 1, leftMax = 0, rightMax = 0, water = 0;
        while (left <= right) {
            if (height[left] <= height[right]) {
                if (height[left] >= leftMax) leftMax = height[left];
                else water += leftMax - height[left];
                left++;
            } else {
                if (height[right] >= rightMax) rightMax = height[right];
                else water += rightMax - height[right];
                right--;
            }
        }
        return water;
    }
}
