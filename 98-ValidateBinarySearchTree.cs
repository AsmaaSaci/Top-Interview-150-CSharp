public class Solution {
    public bool IsValidBST(TreeNode root) {
        return Helper(root, long.MinValue, long.MaxValue);
    }

    private bool Helper(TreeNode node, long min, long max) {
        if (node == null) return true;
        if (node.val <= min || node.val >= max) return false;
        return Helper(node.left, min, node.val) && Helper(node.right, node.val, max);
    }
}
