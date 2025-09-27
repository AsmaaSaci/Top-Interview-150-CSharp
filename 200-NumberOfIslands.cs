public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length, n = grid[0].Length, count = 0;
        void Dfs(int i, int j) {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] != '1') return;
            grid[i][j] = '0';
            Dfs(i + 1, j);
            Dfs(i - 1, j);
            Dfs(i, j + 1);
            Dfs(i, j - 1);
        }
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == '1') {
                    count++;
                    Dfs(i, j);
                }
            }
        }
        return count;
    }
}
