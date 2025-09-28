public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;
        var mapST = new Dictionary<char, char>();
        var mapTS = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++) {
            char cs = s[i], ct = t[i];
            if (mapST.ContainsKey(cs)) {
                if (mapST[cs] != ct) return false;
            } else {
                mapST[cs] = ct;
            }
            if (mapTS.ContainsKey(ct)) {
                if (mapTS[ct] != cs) return false;
            } else {
                mapTS[ct] = cs;
            }
        }
        return true;
    }
}
