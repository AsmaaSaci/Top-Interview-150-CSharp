public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(node);
        map[node] = new Node(node.val);
        while (q.Count > 0) {
            Node curr = q.Dequeue();
            foreach (var nei in curr.neighbors) {
                if (!map.ContainsKey(nei)) {
                    map[nei] = new Node(nei.val);
                    q.Enqueue(nei);
                }
                map[curr].neighbors.Add(map[nei]);
            }
        }
        return map[node];
    }
}
