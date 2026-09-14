public class Solution {
    public bool IsValid(string s) {
        Stack<char> brackets = new Stack<char>();
        Dictionary<char, char> combination = new Dictionary<char, char>();
        combination['('] = ')';
        combination['['] = ']';
        combination['{'] = '}';

        for (int i = 0; i < s.Length; i++){
            if (!combination.Keys.Contains(s[i]) && brackets.Count == 0){
                return false;
            }
            else if (combination.Keys.Contains(s[i])){
                brackets.Push(s[i]);
            }
            else {
                char pop = brackets.Pop();
                if (combination[pop] != s[i]){
                    return false;
                }
            }
        }
        if (brackets.Count == 0)
            return true;

        return false;
    }
}
