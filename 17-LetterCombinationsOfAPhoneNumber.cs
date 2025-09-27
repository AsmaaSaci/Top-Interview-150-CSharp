public class Solution {
    public IList<string> LetterCombinations(string digits) {
        List<string> res = new List<string>();
        if (string.IsNullOrEmpty(digits)) return res;
        string[] map = {
            "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"
        };
        void Backtrack(int idx, string path) {
            if (idx == digits.Length) {
                res.Add(path);
                return;
            }
            string letters = map[digits[idx] - '0'];
            foreach (char c in letters) {
                Backtrack(idx + 1, path + c);
            }
        }
        Backtrack(0, "");
        return res;
    }
}
