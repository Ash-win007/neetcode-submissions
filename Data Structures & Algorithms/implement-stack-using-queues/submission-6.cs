public class MyStack {

    Queue<int> q1 = new Queue<int>();

    public MyStack() {
    }
    
    public void Push(int x) {
        q1.Enqueue(x);
    }
    
    public int Pop() {
        int size = q1.Count;
        for (int i = 0; i < size - 1; i++){
            q1.Enqueue(q1.Dequeue());
        }
        return q1.Dequeue();
    }
    
    public int Top() {
        int size = q1.Count;
        for (int i = 0; i < size - 1; i++){
            q1.Enqueue(q1.Dequeue());
        }
        int topVal = q1.Peek();
        q1.Enqueue(q1.Dequeue());
        return topVal;
    }
    
    public bool Empty() {
        return q1.Count == 0;
    }
}