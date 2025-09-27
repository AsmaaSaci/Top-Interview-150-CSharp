public class Solution {
    public string ReverseWords(string s) {
        var words = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
