public class Solution {
    public int MaxEnvelopes(int[][] envelopes) {
        Array.Sort(envelopes, (a, b) => {
            if (a[0] == b[0]) return b[1].CompareTo(a[1]);
            return a[0].CompareTo(b[0]);
        });

        List<int> lis = new List<int>();
        foreach (var env in envelopes) {
            int h = env[1];
            int idx = lis.BinarySearch(h);
            if (idx < 0) idx = ~idx;
            if (idx == lis.Count) lis.Add(h);
            else lis[idx] = h;
        }

        return lis.Count;
    }
}
