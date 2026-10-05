public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (var s in strs) {
            var count = new int[26];
            foreach (var c in s) {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!groups.ContainsKey(key)) {
                groups[key] = new List<string>();
            }
            groups[key].Add(s);
        }

        return new List<List<string>>(groups.Values);
    }
}