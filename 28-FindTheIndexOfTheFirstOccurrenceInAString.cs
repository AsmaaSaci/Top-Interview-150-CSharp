public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle == "") return 0;
        int n = haystack.Length, m = needle.Length;
        for (int i = 0; i <= n - m; i++) {
            if (haystack.Substring(i, m) == needle) return i;
        }
        return -1;
    }
}
