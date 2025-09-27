public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        TreeNode Build(int left, int right) {
            if (left > right) return null;
            int mid = left + (right - left) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = Build(left, mid - 1);
            node.right = Build(mid + 1, right);
            return node;
        }
        return Build(0, nums.Length - 1);
    }
}
