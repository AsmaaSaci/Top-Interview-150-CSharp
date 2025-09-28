public class Solution {
    private int preIndex = 0;
    
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Build(preorder, inorder, 0, inorder.Length - 1);
    }
    
    private TreeNode Build(int[] preorder, int[] inorder, int inStart, int inEnd) {
        if (inStart > inEnd) return null;
        int rootVal = preorder[preIndex++];
        var root = new TreeNode(rootVal);
        int inIndex = Array.IndexOf(inorder, rootVal, inStart, inEnd - inStart + 1);
        root.left = Build(preorder, inorder, inStart, inIndex - 1);
        root.right = Build(preorder, inorder, inIndex + 1, inEnd);
        return root;
    }
}
