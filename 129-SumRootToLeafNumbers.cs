public class Solution {
    public int SumNumbers(TreeNode root) {
        return DFS(root, 0);
    }
    
    private int DFS(TreeNode node, int current) {
        if (node == null) return 0;
        current = current * 10 + node.val;
        if (node.left == null && node.right == null) return current;
        return DFS(node.left, current) + DFS(node.right, current);
    }
}
