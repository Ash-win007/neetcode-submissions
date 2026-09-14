public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> score = new Stack<int>();    
        int res = 0;
        for (int i = 0; i < operations.Length; i++){
            if (int.TryParse(operations[i], out int val)){
                score.Push(val);
                res += val;
            }
            else if (operations[i] == "C"){
                res -= score.Pop();
            }
            else if (operations[i] == "D"){
                int r = 2 * score.Peek(); 
                score.Push(r); 
                res += r;
            }
            else if (operations[i] == "+"){
                int last = score.Pop();
                int secondLast = score.Peek();
                score.Push(last);
                score.Push(last + secondLast);
                res += last + secondLast;
            }
        }
        return res;
    }
}