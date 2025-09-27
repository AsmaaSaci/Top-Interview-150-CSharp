public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        List<IList<int>> res = new List<IList<int>>();
        void Backtrack(int start, int remain, List<int> path) {
            if (remain == 0) {
                res.Add(new List<int>(path));
                return;
            }
            for (int i = start; i < candidates.Length; i++) {
                if (candidates[i] > remain) continue;
                path.Add(candidates[i]);
                Backtrack(i, remain - candidates[i], path);
                path.RemoveAt(path.Count - 1);
            }
        }
        Backtrack(0, target, new List<int>());
        return res;
    }
}
