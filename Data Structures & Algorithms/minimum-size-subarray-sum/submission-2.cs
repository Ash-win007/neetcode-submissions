public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0, right = 0, sum = 0, n = nums.Length, minLen = int.MaxValue;

        while (right < n){
            sum += nums[right++];
            while (sum >= target){
                minLen = Math.Min(minLen, right - left);
                sum -= nums[left++];

            }
        }

        return minLen == int.MaxValue ? 0 : minLen;
    }
}