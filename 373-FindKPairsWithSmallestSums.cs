using System;
using System.Collections.Generic;

public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        var result = new List<IList<int>>();
        if (nums1.Length == 0 || nums2.Length == 0 || k == 0) return result;

        var pq = new PriorityQueue<(int i, int j, int sum), int>();
        for (int i = 0; i < nums1.Length && i < k; i++) {
            pq.Enqueue((i, 0, nums1[i] + nums2[0]), nums1[i] + nums2[0]);
        }

        while (pq.Count > 0 && result.Count < k) {
            var (i, j, sum) = pq.Dequeue();
            result.Add(new List<int>{ nums1[i], nums2[j] });
            if (j + 1 < nums2.Length) {
                pq.Enqueue((i, j + 1, nums1[i] + nums2[j + 1]), nums1[i] + nums2[j + 1]);
            }
        }

        return result;
    }
}
