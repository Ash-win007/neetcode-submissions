public class MinStack {

    public Stack<int> stack;
    public Stack<int> lowest;
    public MinStack() {
        stack = new Stack<int>();
        lowest = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (lowest.Count == 0 || lowest.Peek() >= val){
            lowest.Push(val);
        }     
    }
    
    public void Pop() {
        int val = stack.Pop();
        if (val == lowest.Peek())
            lowest.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return lowest.Peek();
    }
}
