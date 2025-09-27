public class Solution {
    public int LengthOfLIS(int[] nums) {
        List<int> lis = new List<int>();
        foreach (int num in nums) {
            int i = lis.BinarySearch(num);
            if (i < 0) i = ~i;
            if (i == lis.Count) lis.Add(num);
            else lis[i] = num;
        }
        return lis.Count;
    }
}
