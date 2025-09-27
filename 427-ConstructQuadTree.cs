public class Solution {
    public Node Construct(int[][] grid) {
        int n = grid.Length;
        Node Build(int r0, int c0, int size) {
            if (size == 1) return new Node(grid[r0][c0] == 1, true);
            int newSize = size / 2;
            Node topLeft = Build(r0, c0, newSize);
            Node topRight = Build(r0, c0 + newSize, newSize);
            Node bottomLeft = Build(r0 + newSize, c0, newSize);
            Node bottomRight = Build(r0 + newSize, c0 + newSize, newSize);
            if (topLeft.isLeaf && topRight.isLeaf && bottomLeft.isLeaf && bottomRight.isLeaf &&
                topLeft.val == topRight.val && topLeft.val == bottomLeft.val && topLeft.val == bottomRight.val)
                return new Node(topLeft.val, true);
            return new Node(false, false, topLeft, topRight, bottomLeft, bottomRight);
        }
        return Build(0, 0, n);
    }
}
