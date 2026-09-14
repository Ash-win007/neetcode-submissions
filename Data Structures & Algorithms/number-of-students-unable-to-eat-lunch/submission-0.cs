public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Stack<int> stack = new Stack<int>(sandwiches.Reverse());
        Queue<int> queue = new Queue<int>(students);
        int count = sandwiches.Length, i;
        while (stack.Count > 0 && queue.Contains(stack.Peek())){

            //Console.Write(stack.Count + "stack \n");
            //Console.Write(queue.Count + "queue \n");

            var student = queue.Dequeue();
            var top = stack.Peek();

            if (student == top){
                Console.Write("true" + stack.Count + "\n");

                stack.Pop();
            }
            else{
                queue.Enqueue(student);
            }
        }
        return queue.Count;
    }
}