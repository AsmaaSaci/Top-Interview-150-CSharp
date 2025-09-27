public class WordDictionary {
    private class TrieNode {
        public bool IsEnd;
        public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    }

    private TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }

    public void AddWord(string word) {
        var node = root;
        foreach (char c in word) {
            if (!node.Children.ContainsKey(c)) {
                node.Children[c] = new TrieNode();
            }
            node = node.Children[c];
        }
        node.IsEnd = true;
    }

    public bool Search(string word) {
        return Dfs(word, 0, root);
    }

    private bool Dfs(string word, int index, TrieNode node) {
        if (index == word.Length) return node.IsEnd;
        char c = word[index];
        if (c == '.') {
            foreach (var child in node.Children.Values) {
                if (Dfs(word, index + 1, child)) return true;
            }
            return false;
        } else {
            if (!node.Children.ContainsKey(c)) return false;
            return Dfs(word, index + 1, node.Children[c]);
        }
    }
}
