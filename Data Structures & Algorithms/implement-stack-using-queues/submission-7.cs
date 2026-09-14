public class MyStack {

    Queue<int> q1 = new Queue<int>();

    public MyStack() {
    }
    
    public void Push(int x) {
        q1.Enqueue(x);
        int size = q1.Count;
        
        // Rotate so the newly added element is at the front.
        for (int i = 0; i < size - 1; i++) {
            q1.Enqueue(q1.Dequeue());
        }
    }
    
    public int Pop() {
        return q1.Dequeue();
    }
    
    public int Top() {
        return q1.Peek();
    }
    
    public bool Empty() {
        return q1.Count == 0;
    }
}