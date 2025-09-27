public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        for (int i = 0; i < n; i++) {
            for (int j = i + 1; j < n; j++) {
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = tmp;
            }
        }
        for (int i = 0; i < n; i++) {
            Array.Reverse(matrix[i]);
        }
    }
}
