public class LRUCache {
    private int capacity;
    private Dictionary<int, LinkedListNode<(int key, int value)>> map;
    private LinkedList<(int key, int value)> list;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        map = new Dictionary<int, LinkedListNode<(int key, int value)>>();
        list = new LinkedList<(int key, int value)>();
    }
    
    public int Get(int key) {
        if (!map.ContainsKey(key)) return -1;
        var node = map[key];
        list.Remove(node);
        list.AddFirst(node);
        return node.Value.value;
    }
    
    public void Put(int key, int value) {
        if (map.ContainsKey(key)) {
            var node = map[key];
            list.Remove(node);
        } else if (map.Count == capacity) {
            var last = list.Last;
            map.Remove(last.Value.key);
            list.RemoveLast();
        }
        var newNode = new LinkedListNode<(int key, int value)>((key, value));
        list.AddFirst(newNode);
        map[key] = newNode;
    }
}
