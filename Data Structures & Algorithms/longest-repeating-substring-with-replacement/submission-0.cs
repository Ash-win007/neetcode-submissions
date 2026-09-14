public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int maxLength = 0;
        int mostFrequentCount = 0;
        int[] charFreq = new int[26];
        
        for (int right = 0; right < s.Length; right++) {
            // Add new character to window
            charFreq[s[right] - 'A']++;
            
            // Update most frequent character count
            mostFrequentCount = Math.Max(mostFrequentCount, charFreq[s[right] - 'A']);
            
            // Calculate how many characters we'd need to replace
            int windowLength = right - left + 1;
            int replacementsNeeded = windowLength - mostFrequentCount;
            
            // If too many replacements needed, shrink window
            if (replacementsNeeded > k) {
                charFreq[s[left] - 'A']--;
                left++;
            }
            
            // Update max length (window is valid after possible shrink)
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        
        return maxLength;
    }
}