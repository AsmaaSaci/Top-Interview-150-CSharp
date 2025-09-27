public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;
        var rows = new StringBuilder[Math.Min(numRows, s.Length)];
        for (int i = 0; i < rows.Length; i++) rows[i] = new StringBuilder();
        int curRow = 0;
        bool goingDown = false;
        foreach (char c in s) {
            rows[curRow].Append(c);
            if (curRow == 0 || curRow == numRows - 1) goingDown = !goingDown;
            curRow += goingDown ? 1 : -1;
        }
        var result = new StringBuilder();
        foreach (var row in rows) result.Append(row);
        return result.ToString();
    }
}
