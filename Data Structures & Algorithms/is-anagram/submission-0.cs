public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;
        Dictionary<char, int> count = new Dictionary<char, int>();
        
        for (int i = 0; i < s.Length; i++){
            if (count.TryGetValue(s[i], out int c)){
                count[s[i]] = c + 1;
            }
            else{
                count[s[i]] = 1;
            }

            if (count.TryGetValue(t[i], out int d)){
                count[t[i]] = d - 1; 
            }
            else{
                count[t[i]] = -1;
            }
        }

        foreach (var c in count)
        {
            if (c.Value != 0)
                return false;
        }
        
        return true;
    }
}
