using System;
using System.Collections.Generic;

public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length == 0 || t.Length == 0) return "";
        var dictT = new Dictionary<char, int>();
        foreach (char c in t) {
            if (!dictT.ContainsKey(c)) dictT[c] = 0;
            dictT[c]++;
        }

        int required = dictT.Count;
        int l = 0, r = 0, formed = 0;
        var windowCounts = new Dictionary<char, int>();
        int[] ans = {-1, 0, 0}; // length, left, right

        while (r < s.Length) {
            char c = s[r];
            if (!windowCounts.ContainsKey(c)) windowCounts[c] = 0;
            windowCounts[c]++;
            if (dictT.ContainsKey(c) && windowCounts[c] == dictT[c]) formed++;

            while (l <= r && formed == required) {
                if (ans[0] == -1 || r - l + 1 < ans[0]) {
                    ans[0] = r - l + 1;
                    ans[1] = l;
                    ans[2] = r;
                }

                char cl = s[l];
                windowCounts[cl]--;
                if (dictT.ContainsKey(cl) && windowCounts[cl] < dictT[cl]) formed--;
                l++;
            }

            r++;
        }

        return ans[0] == -1 ? "" : s.Substring(ans[1], ans[0]);
    }
}
