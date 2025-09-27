public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        void Backtrack(string curr, int open, int close) {
            if (curr.Length == n * 2) {
                res.Add(curr);
                return;
            }
            if (open < n) Backtrack(curr + "(", open + 1, close);
            if (close < open) Backtrack(curr + ")", open, close + 1);
        }
        Backtrack("", 0, 0);
        return res;
    }
}
