var Trie = function() {
    this.children = {};
    this.isEnd = false;
};

Trie.prototype.insert = function(word) {
    let node = this;
    for (let char of word) {
        if (!node.children[char]) node.children[char] = new Trie();
        node = node.children[char];
    }
    node.isEnd = true;
};

Trie.prototype.search = function(word) {
    let node = this;
    for (let char of word) {
        if (!node.children[char]) return false;
        node = node.children[char];
    }
    return node.isEnd;
};

Trie.prototype.startsWith = function(prefix) {
    let node = this;
    for (let char of prefix) {
        if (!node.children[char]) return false;
        node = node.children[char];
    }
    return true;
};
