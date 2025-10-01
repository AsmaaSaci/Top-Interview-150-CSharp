public class Solution {
    public int[] FindRightInterval(int[][] intervals) {
        int n = intervals.Length;
        int[] result = new int[n];
        var map = new List<(int start, int index)>();
        
        for (int i = 0; i < n; i++) {
            map.Add((intervals[i][0], i));
        }
        map.Sort((a, b) => a.start.CompareTo(b.start));
        
        for (int i = 0; i < n; i++) {
            int target = intervals[i][1];
            int left = 0, right = n - 1, idx = -1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (map[mid].start >= target) {
                    idx = map[mid].index;
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
            result[i] = idx;
        }
        
        return result;
    }
}
