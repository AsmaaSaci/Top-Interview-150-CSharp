public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        int n = citations.Length;
        for (int i = 0; i < n; i++) {
            int h = n - i;
            if (citations[i] >= h) return h;
        }
        return 0;
    }
}
