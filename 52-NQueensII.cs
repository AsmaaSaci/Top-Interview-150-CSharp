public class Solution {
    public int TotalNQueens(int n) {
        int count = 0;
        bool[] cols = new bool[n];
        bool[] diag1 = new bool[2 * n];
        bool[] diag2 = new bool[2 * n];
        void Backtrack(int row) {
            if (row == n) {
                count++;
                return;
            }
            for (int col = 0; col < n; col++) {
                if (cols[col] || diag1[row + col] || diag2[row - col + n]) continue;
                cols[col] = diag1[row + col] = diag2[row - col + n] = true;
                Backtrack(row + 1);
                cols[col] = diag1[row + col] = diag2[row - col + n] = false;
            }
        }
        Backtrack(0);
        return count;
    }
}
