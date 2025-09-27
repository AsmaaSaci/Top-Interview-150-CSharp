public class Solution {
    private int count = 0;
    private int result = 0;

    public int KthSmallest(TreeNode root, int k) {
        InOrder(root, k);
        return result;
    }

    private void InOrder(TreeNode node, int k) {
        if (node == null) return;
        InOrder(node.left, k);
        count++;
        if (count == k) {
            result = node.val;
            return;
        }
        InOrder(node.right, k);
    }
}
