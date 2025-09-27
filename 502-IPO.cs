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

        var maxHeap = new SortedSet<(int prof, int index)>(Comparer<(int prof, int index)>.Create(
            (a, b) => a.prof == b.prof ? a.index - b.index : b.prof - a.prof
        ));

        int idx = 0;
        for (int i = 0; i < k; i++) {
