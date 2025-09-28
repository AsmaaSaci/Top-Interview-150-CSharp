public class Solution {
    public void Flatten(TreeNode root) {
        if (root == null) return;
        Flatten(root.left);
        Flatten(root.right);
        if (root.left != null) {
            var right = root.right;
            root.right = root.left;
            root.left = null;
            var curr = root.right;
            while (curr.right != null) curr = curr.right;
            curr.right = right;
        }
    }
}
