public class Solution {
    public void GameOfLife(int[][] board) {
        int m = board.Length, n = board[0].Length;
        int[] dirs = {0, 1, -1};
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                int live = 0;
                foreach (int x in dirs) {
                    foreach (int y in dirs) {
                        if (x == 0 && y == 0) continue;
                        int r = i + x, c = j + y;
                        if (r >= 0 && r < m && c >= 0 && c < n && (board[r][c] & 1) == 1) live++;
                    }
                }
                if ((board[i][j] & 1) == 1 && (live == 2 || live == 3)) board[i][j] |= 2;
                if ((board[i][j] & 1) == 0 && live == 3) board[i][j] |= 2;
            }
        }
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                board[i][j] >>= 1;
            }
        }
    }
}
