public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0, right = s.Length - 1;
        while (left < right){
            if (!char.IsLetter(s[left]) && !char.IsNumber(s[left]))
            {
                left++;
            }
            else if (!char.IsLetter(s[right]) && !char.IsNumber(s[right])){
                right--;
            }
            else {
                if (char.ToUpperInvariant(s[left]) == char.ToUpperInvariant(s[right])){
                    left++;
                    right--;
                }
                else{
                    return false;
                }
            }
                Console.Write("\nLeft" + s[left]);
                Console.Write("\nRight" + s[right]);
        }
        return true;
    }
}
