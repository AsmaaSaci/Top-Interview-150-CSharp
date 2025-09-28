public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();
        foreach (var s in strs) {
            var arr = s.ToCharArray();
            Array.Sort(arr);
            string key = new string(arr);
            if (!map.ContainsKey(key)) map[key] = new List<string>();
            map[key].Add(s);
        }
        return map.Values.ToList<IList<string>>();
    }
}
