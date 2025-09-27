using System;
using System.Collections.Generic;

public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        int n = profits.Length;
        var projects = new List<(int cap, int prof)>();
        for (int i = 0; i < n; i++) {
            projects.Add((capital[i], profits[i]));
        }
        projects.Sort((a, b) => a.cap.CompareTo(b.cap));

        var maxHeap = new PriorityQueue<int, int>(); // max-heap by using negative priority
        int idx = 0;
        for (int i = 0; i < k; i++) {
            while (idx < n && projects[idx].cap <= w) {
                maxHeap.Enqueue(projects[idx].prof, -projects[idx].prof);
                idx++;
            }
            if (maxHeap.Count == 0) break;
            w += maxHeap.Dequeue();
        }
        return w;
    }
}
