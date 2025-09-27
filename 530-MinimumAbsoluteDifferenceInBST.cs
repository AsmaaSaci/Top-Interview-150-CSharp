public class Solution {
    private int prev = -1;
    private int minDiff = int.MaxValue;

    public int GetMinimumDifference(TreeNode root) {
        InOrder(root);
        return minDiff;
    }

    private void InOrder(TreeNode node) {
        if (node == null) return;
        InOrder(node.left);
        if (prev != -1) minDiff = Math.Min(minDiff, node.val - prev);
        prev = node.val;
        InOrder(node.right);
    }
}
