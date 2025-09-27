public class Solution {
    public int HammingWeight(int n) {
        int count = 0;
        while (n != 0) {
            count += n & 1;
            n = (int)((uint)n >> 1);
        }
        return count;
    }
}
