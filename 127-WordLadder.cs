using System;
using System.Collections.Generic;

public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var wordSet = new HashSet<string>(wordList);
        if (!wordSet.Contains(endWord)) return 0;

        var queue = new Queue<(string word, int steps)>();
        queue.Enqueue((beginWord, 1));

        while (queue.Count > 0) {
            var (word, steps) = queue.Dequeue();
            if (word == endWord) return steps;

            char[] arr = word.ToCharArray();
            for (int i = 0; i < arr.Length; i++) {
                char old = arr[i];
                for (char c = 'a'; c <= 'z'; c++) {
                    if (c == old) continue;
                    arr[i] = c;
                    string next = new string(arr);
                    if (wordSet.Contains(next)) {
                        queue.Enqueue((next, steps + 1));
                        wordSet.Remove(next);
                    }
                }
                arr[i] = old;
            }
        }

        return 0;
    }
}
