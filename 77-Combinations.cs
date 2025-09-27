public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> res = new List<IList<int>>();
        void Backtrack(int start, List<int> comb) {
            if (comb.Count == k) {
                res.Add(new List<int>(comb));
                return;
            }
            for (int i = start; i <= n; i++) {
                comb.Add(i);
                Backtrack(i + 1, comb);
                comb.RemoveAt(comb.Count - 1);
            }
        }
        Backtrack(1, new List<int>());
        return res;
    }
}
