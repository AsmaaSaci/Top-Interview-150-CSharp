using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        var result = new List<int>();
        if (s.Length == 0 || words.Length == 0) return result;

        int wordLen = words[0].Length;
        int wordCount = words.Length;
        int totalLen = wordLen * wordCount;
        var dict = new Dictionary<string, int>();
        foreach (var w in words) {
            if (!dict.ContainsKey(w)) dict[w] = 0;
            dict[w]++;
        }

        for (int i = 0; i < wordLen; i++) {
            int left = i, right = i, count = 0;
            var window = new Dictionary<string, int>();
            while (right + wordLen <= s.Length) {
                string word = s.Substring(right, wordLen);
                right += wordLen;
                if (dict.ContainsKey(word)) {
                    if (!window.ContainsKey(word)) window[word] = 0;
                    window[word]++;
                    count++;
                    while (window[word] > dict[word]) {
                        string leftWord = s.Substring(left, wordLen);
                        window[leftWord]--;
                        left += wordLen;
                        count--;
                    }
                    if (count == wordCount) result.Add(left);
                } else {
                    window.Clear();
                    count = 0;
                    left = right;
                }
            }
        }

        return result;
    }
}
