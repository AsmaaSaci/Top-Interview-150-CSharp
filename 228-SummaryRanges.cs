public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> res = new List<string>();
        int i = 0;
        while (i < nums.Length) {
            int start = nums[i];
            while (i + 1 < nums.Length && nums[i + 1] == nums[i] + 1) i++;
            if (start == nums[i]) res.Add(start.ToString());
            else res.Add(start + "->" + nums[i]);
            i++;
        }
        return res;
    }
}
