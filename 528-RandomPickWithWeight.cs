public class Solution {
    private int[] prefix;
    private int total;
    private Random rand;

    public Solution(int[] w) {
        prefix = new int[w.Length];
        prefix[0] = w[0];
        for (int i = 1; i < w.Length; i++) {
            prefix[i] = prefix[i - 1] + w[i];
        }
        total = prefix[prefix.Length - 1];
        rand = new Random();
    }
    
    public int PickIndex() {
        int target = rand.Next(1, total + 1);
        int left = 0, right = prefix.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (prefix[mid] < target) left = mid + 1;
            else right = mid;
        }
        return left;
    }
}
