public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> res = new List<int>();
        if (matrix.Length == 0) return res;
        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;
        while (top <= bottom && left <= right) {
            for (int j = left; j <= right; j++) res.Add(matrix[top][j]);
            top++;
            for (int i = top; i <= bottom; i++) res.Add(matrix[i][right]);
            right--;
            if (top <= bottom) {
                for (int j = right; j >= left; j--) res.Add(matrix[bottom][j]);
                bottom--;
            }
            if (left <= right) {
                for (int i = bottom; i >= top; i--) res.Add(matrix[i][left]);
                left++;
            }
        }
        return res;
    }
}
