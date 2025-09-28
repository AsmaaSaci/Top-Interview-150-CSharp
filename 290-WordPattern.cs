public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split(' ');
        if (pattern.Length != words.Length) return false;
        var mapP = new Dictionary<char, string>();
        var mapW = new Dictionary<string, char>();
        for (int i = 0; i < pattern.Length; i++) {
            char p = pattern[i];
            string w = words[i];
            if (mapP.ContainsKey(p)) {
                if (mapP[p] != w) return false;
            } else {
                mapP[p] = w;
            }
            if (mapW.ContainsKey(w)) {
                if (mapW[w] != p) return false;
            } else {
                mapW[w] = p;
            }
        }
        return true;
    }
}
