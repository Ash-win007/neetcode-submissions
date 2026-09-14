public class LRUCache
{
    private readonly int capacity;

    private readonly Dictionary<int, LinkedListNode<(int key, int value)>> dict = new();
    private readonly LinkedList<(int key, int value)> list = new();

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (!dict.TryGetValue(key, out var node))
            return -1;

        // Move to front because it was just used
        list.Remove(node);
        list.AddFirst(node);

        return node.Value.value;
    }

    public void Put(int key, int value)
    {
        if (dict.TryGetValue(key, out var node))
        {
            // Update value
            node.Value = (key, value);

            // Move to front
            list.Remove(node);
            list.AddFirst(node);

            return;
        }

        // Add new item
        var newNode = list.AddFirst((key, value));
        dict[key] = newNode;

        // Remove least recently used
        if (dict.Count > capacity)
        {
            var lru = list.Last!;

            list.RemoveLast();
            dict.Remove(lru.Value.key);
        }
    }
}