public class Solution {
    private int postIndex;
    
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        postIndex = postorder.Length - 1;
        return Build(inorder, postorder, 0, inorder.Length - 1);
    }
    
    private TreeNode Build(int[] inorder, int[] postorder, int inStart, int inEnd) {
        if (inStart > inEnd) return null;
        int rootVal = postorder[postIndex--];
        var root = new TreeNode(rootVal);
        int inIndex = Array.IndexOf(inorder, rootVal, inStart, inEnd - inStart + 1);
        root.right = Build(inorder, postorder, inIndex + 1, inEnd);
        root.left = Build(inorder, postorder, inStart, inIndex - 1);
        return root;
    }
}
