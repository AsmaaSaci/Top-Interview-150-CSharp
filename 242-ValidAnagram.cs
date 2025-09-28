public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        var counts = new int[26];
        foreach (var c in s) counts[c - 'a']++;
        foreach (var c in t) {
            if (--counts[c - 'a'] < 0) return false;
        }
        return true;
    }
}
