public class LRUCache {
    LinkedList<int> list = new LinkedList<int>();
    Dictionary<int, LinkedListNode<int>> dict = new Dictionary<int, LinkedListNode<int>>();
    Dictionary<int, int> values = new Dictionary<int, int>();

    int totalCapacity;
    
    public LRUCache(int capacity) {
        totalCapacity = capacity;
    }
    
    public int Get(int key) {
        if (!values.ContainsKey(key)) {
            return -1;
        }
        list.Remove(dict[key]);
        dict[key] = list.AddFirst(key);
        return values[key];
    }
    
    public void Put(int key, int value) {
        if (values.ContainsKey(key)) {
            values[key] = value;
            list.Remove(dict[key]);
            dict[key] = list.AddFirst(key);
            return;
        }

        values[key] = value;
        dict[key] = list.AddFirst(key);
        
        if (values.Count > totalCapacity) {
            var lru = list.Last();
            values.Remove(lru);
            dict.Remove(lru);
            list.RemoveLast();
        }
    }
}