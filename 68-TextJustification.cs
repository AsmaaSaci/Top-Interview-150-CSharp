public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var result = new List<string>();
        int i = 0;
        while (i < words.Length) {
            int j = i, lineLength = 0;
            while (j < words.Length && lineLength + words[j].Length + (j - i) <= maxWidth) {
                lineLength += words[j].Length;
                j++;
            }
            int spaces = maxWidth - lineLength;
            int gaps = j - i - 1;
            var sb = new StringBuilder();
            if (j == words.Length || gaps == 0) {
                for (int k = i; k < j; k++) {
                    sb.Append(words[k]);
                    if (k != j - 1) sb.Append(' ');
                }
                sb.Append(' ', maxWidth - sb.Length);
            } else {
                int spacePerGap = spaces / gaps;
                int extra = spaces % gaps;
                for (int k = i; k < j; k++) {
                    sb.Append(words[k]);
                    if (k != j - 1) sb.Append(' ', spacePerGap + (extra-- > 0 ? 1 : 0));
                }
            }
            result.Add(sb.ToString());
            i = j;
        }
        return result;
    }
}
