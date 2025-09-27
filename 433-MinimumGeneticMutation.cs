using System;
using System.Collections.Generic;

public class Solution {
    public int MinMutation(string startGene, string endGene, string[] bank) {
        var bankSet = new HashSet<string>(bank);
        if (!bankSet.Contains(endGene)) return -1;
        char[] genes = new char[] {'A','C','G','T'};
        var queue = new Queue<(string gene, int steps)>();
        queue.Enqueue((startGene, 0));
        var visited = new HashSet<string>{startGene};

        while (queue.Count > 0) {
            var (gene, steps) = queue.Dequeue();
            if (gene == endGene) return steps;

            char[] arr = gene.ToCharArray();
            for (int i = 0; i < arr.Length; i++) {
                char old = arr[i];
                foreach (char g in genes) {
                    if (g == old) continue;
                    arr[i] = g;
                    string next = new string(arr);
                    if (bankSet.Contains(next) && !visited.Contains(next)) {
                        visited.Add(next);
                        queue.Enqueue((next, steps + 1));
                    }
                }
                arr[i] = old;
            }
        }

        return -1;
    }
}
