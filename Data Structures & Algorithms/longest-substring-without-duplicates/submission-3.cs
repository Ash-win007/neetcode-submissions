public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int cur = 0, n = s.Length, left = 0, right = 0, maxLen = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>();

        while (right < n){
            if (dict.TryGetValue(s[right], out int val) && val >= 1){
                dict[s[left++]] -= 1;
                maxLen = Math.Max(maxLen, cur);
                cur -= 1;
            }
            else{
                if (val != 0)
                    dict[s[right]] += 1;
                else
                    dict[s[right]] = 1;

                cur+=1;
                right++;
            }
        }
        return Math.Max(maxLen, cur);
    }
}
