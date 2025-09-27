public class Solution {
    public int MaxPoints(int[][] points) {
        if (points.Length <= 2) return points.Length;
        int maxPoints = 0;
        for (int i = 0; i < points.Length; i++) {
            Dictionary<(int, int), int> map = new Dictionary<(int, int), int>();
            int overlap = 0, curMax = 0;
            for (int j = i + 1; j < points.Length; j++) {
                int dx = points[j][0] - points[i][0];
                int dy = points[j][1] - points[i][1];
                if (dx == 0 && dy == 0) {
                    overlap++;
                    continue;
                }
                int g = GCD(dx, dy);
                dx /= g;
                dy /= g;
                if (dx < 0) { dx = -dx; dy = -dy; }
                else if (dx == 0) dy = 1;
                else if (dy == 0) dx = 1;
                var slope = (dx, dy);
                if (!map.ContainsKey(slope)) map[slope] = 0;
                map[slope]++;
                curMax = Math.Max(curMax, map[slope]);
            }
            maxPoints = Math.Max(maxPoints, curMax + overlap + 1);
        }
        return maxPoints;
    }

    private int GCD(int a, int b) {
        if (b == 0) return a;
        return GCD(b, a % b);
    }
}
