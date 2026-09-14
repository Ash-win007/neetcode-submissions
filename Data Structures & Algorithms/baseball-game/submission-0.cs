public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> score = new Stack<int>();    
        for (int i = 0; i < operations.Length; i++){
            if (int.TryParse(operations[i], out int val)){
                score.Push(val);
            }
            else if (operations[i] == "C"){
                score.Pop();
            }
            else if (operations[i] == "D"){
                score.Push(score.Peek() * 2);
            }
            else if (operations[i] == "+"){
                int last = score.Pop();
                int secondLast = score.Peek();
                score.Push(last);
                score.Push(last + secondLast);
            }
        }
        return score.Sum();
    }
}