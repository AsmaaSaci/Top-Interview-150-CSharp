public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                char c = board[i][j];
                if (c != '.') {
                    if (!seen.Add(c + " in row " + i) ||
                        !seen.Add(c + " in col " + j) ||
                        !seen.Add(c + " in block " + i / 3 + "-" + j / 3))
                        return false;
                }
            }
        }
        return true;
    }
}
