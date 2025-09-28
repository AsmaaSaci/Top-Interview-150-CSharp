public class Solution {
    private int maxSum = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        MaxGain(root);
        return maxSum;
    }
    
    private int MaxGain(TreeNode node) {
        if (node == null) return 0;
        int left = Math.Max(MaxGain(node.left), 0);
        int right = Math.Max(MaxGain(node.right), 0);
        int priceNewPath = node.val + left + right;
        maxSum = Math.Max(maxSum, priceNewPath);
        return node.val + Math.Max(left, right);
    }
}
