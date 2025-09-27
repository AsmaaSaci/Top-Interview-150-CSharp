using System;
using System.Collections.Generic;

public class Solution {
    public int SnakesAndLadders(int[][] board) {
        int n = board.Length;
        int[] visited = new int[n * n + 1];
        Array.Fill(visited, -1);

        Queue<(int pos, int moves)> q = new Queue<(int, int)>();
        q.Enqueue((1, 0));
        visited[1] = 0;

        while (q.Count > 0) {
            var (pos, moves) = q.Dequeue();
            for (int i = 1; i <= 6; i++) {
                int next = pos + i;
                if (next > n * n) break;
                int r = n - 1 - (next - 1) / n;
                int c = ((next - 1) % n);
                if ((n - 1 - r) % 2 == 1) c = n - 1 - c;
                if (board[r][c] != -1) next = board[r][c];
                if (visited[next] == -1) {
                    visited[next] = moves + 1;
                    q.Enqueue((next, moves + 1));
                }
            }
        }

        return visited[n * n];
    }
}
