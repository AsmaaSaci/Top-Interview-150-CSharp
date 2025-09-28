public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var counts = new int[26];
        foreach (var c in magazine) counts[c - 'a']++;
        foreach (var c in ransomNote) {
            if (--counts[c - 'a'] < 0) return false;
        }
        return true;
    }
}
