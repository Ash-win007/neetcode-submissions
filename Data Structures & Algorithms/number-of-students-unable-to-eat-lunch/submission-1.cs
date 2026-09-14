public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Stack<int> stack = new Stack<int>(sandwiches.Reverse());
        Queue<int> queue = new Queue<int>(students);
        int count = sandwiches.Length, i;
        while (stack.Count > 0 && queue.Contains(stack.Peek())){
            var student = queue.Dequeue();
            var top = stack.Peek();

            if (student == top){
                stack.Pop();
            }
            else{
                queue.Enqueue(student);
            }
        }
        return queue.Count;
    }
}