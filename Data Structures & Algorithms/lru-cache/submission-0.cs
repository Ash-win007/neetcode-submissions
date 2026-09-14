public class LRUCache {
    LinkedList<int> list = new LinkedList<int>();
    Dictionary<int, int> dict = new Dictionary<int, int>();

    int totalCapacity;
    
    public LRUCache(int capacity) {
        totalCapacity = capacity;
    }
    
    public int Get(int key) {
        if (!dict.TryGetValue(key, out int val)){
            return -1;
        }
        list.Remove(key);
        list.AddFirst(key);
        return dict[key];
    }
    
    public void Put(int key, int value) {
        if (dict.TryGetValue(key, out int val)){
            dict[key] = value;
            list.Remove(key);
            list.AddFirst(key);
            return;
        }

        dict[key] = value;
        list.AddFirst(key);
        if (dict.Count > totalCapacity){
            var lru = list.Last();
            dict.Remove(lru);
            list.RemoveLast();
        }
    }
}
