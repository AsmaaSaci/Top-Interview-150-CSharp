public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        void Backtrack(List<int> path, bool[] used) {
            if (path.Count == nums.Length) {
                res.Add(new List<int>(path));
                return;
            }
            for (int i = 0; i < nums.Length; i++) {
                if (used[i]) continue;
                used[i] = true;
                path.Add(nums[i]);
                Backtrack(path, used);
                path.RemoveAt(path.Count - 1);
                used[i] = false;
            }
        }
        Backtrack(new List<int>(), new bool[nums.Length]);
        return res;
    }
}
