public class Solution {
    private class TrieNode {
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
        public string Word = null;
    }

    public IList<string> FindWords(char[][] board, string[] words) {
        var result = new List<string>();
        TrieNode root = BuildTrie(words);
        int rows = board.Length, cols = board[0].Length;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (root.Children.ContainsKey(board[r][c])) {
                    Dfs(board, r, c, root, result);
                }
            }
        }
        return result;
    }

    private void Dfs(char[][] board, int r, int c, TrieNode node, IList<string> result) {
        char ch = board[r][c];
        if (!node.Children.ContainsKey(ch)) return;
        TrieNode nextNode = node.Children[ch];

        if (nextNode.Word != null) {
            result.Add(nextNode.Word);
            nextNode.Word = null;
        }

        board[r][c] = '#';
        int[][] dirs = new int[][] {
            new int[]{1,0}, new int[]{-1,0}, new int[]{0,1}, new int[]{0,-1}
        };
        foreach (var d in dirs) {
            int nr = r + d[0], nc = c + d[1];
            if (nr >= 0 && nr < board.Length && nc >= 0 && nc < board[0].Length && board[nr][nc] != '#') {
                Dfs(board, nr, nc, nextNode, result);
            }
        }
        board[r][c] = ch;

        if (nextNode.Children.Count == 0) {
            node.Children.Remove(ch);
        }
    }

    private TrieNode BuildTrie(string[] words) {
        TrieNode root = new TrieNode();
        foreach (var word in words) {
            TrieNode node = root;
            foreach (char c in word) {
                if (!node.Children.ContainsKey(c)) {
                    node.Children[c] = new TrieNode();
                }
                node = node.Children[c];
            }
            node.Word = word;
        }
        return root;
    }
}
