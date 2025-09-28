public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);
        int maxLen = 0;
        foreach (var num in set) {
            if (!set.Contains(num - 1)) {
                int current = num, length = 1;
                while (set.Contains(current + 1)) {
                    current++;
                    length++;
                }
                maxLen = Math.Max(maxLen, length);
            }
        }
        return maxLen;
    }
}
