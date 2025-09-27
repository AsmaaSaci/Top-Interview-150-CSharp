public class Solution {
    public int FindMinArrowShots(int[][] points) {
        if (points.Length == 0) return 0;
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
        int arrows = 1;
        int end = points[0][1];
        for (int i = 1; i < points.Length; i++) {
            if (points[i][0] > end) {
                arrows++;
                end = points[i][1];
            }
        }
        return arrows;
    }
}
