public class Solution {
    public Node CopyRandomList(Node head) {
        if (head == null) return null;
        var map = new Dictionary<Node, Node>();
        Node current = head;
        while (current != null) {
            map[current] = new Node(current.val);
            current = current.next;
        }
        current = head;
        while (current != null) {
            map[current].next = current.next != null ? map[current.next] : null;
            map[current].random = current.random != null ? map[current.random] : null;
            current = current.next;
        }
        return map[head];
    }
}
