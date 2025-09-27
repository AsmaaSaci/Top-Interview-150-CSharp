public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0) return new int[0][];
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> res = new List<int[]>();
        int[] curr = intervals[0];
        foreach (var inter in intervals) {
            if (inter[0] <= curr[1]) {
                curr[1] = Math.Max(curr[1], inter[1]);
            } else {
                res.Add(curr);
                curr = inter;
            }
        }
        res.Add(curr);
        return res.ToArray();
    }
}
