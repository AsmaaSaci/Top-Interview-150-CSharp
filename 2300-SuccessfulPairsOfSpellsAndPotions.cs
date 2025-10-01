public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        int n = spells.Length;
        int m = potions.Length;
        int[] result = new int[n];
        
        for (int i = 0; i < n; i++) {
            long spell = spells[i];
            int left = 0, right = m - 1, idx = m;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (spell * potions[mid] >= success) {
                    idx = mid;
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
            result[i] = m - idx;
        }
        
        return result;
    }
}
