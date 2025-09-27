public class Solution {
    public void Solve(char[][] board) {
        int m = board.Length;
        if (m == 0) return;
        int n = board[0].Length;
        void Dfs(int i, int j) {
            if (i < 0 || i >= m || j < 0 || j >= n || board[i][j] != 'O') return;
            board[i][j] = '#';
            Dfs(i + 1, j);
            Dfs(i - 1, j);
            Dfs(i, j + 1);
            Dfs(i, j - 1);
        }
        for (int i = 0; i < m; i++) {
            Dfs(i, 0);
            Dfs(i, n - 1);
        }
        for (int j = 0; j < n; j++) {
            Dfs(0, j);
            Dfs(m - 1, j);
        }
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (board[i][j] == 'O') board[i][j] = 'X';
                else if (board[i][j] == '#') board[i][j] = 'O';
            }
        }
    }
}
