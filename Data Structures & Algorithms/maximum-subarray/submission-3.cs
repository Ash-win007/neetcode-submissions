public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum = nums[0];
        int curSum = 0;
        
        foreach (var n in nums){
            if (curSum < 0) {
                curSum = 0;
            }
            curSum += n;
            maxSum = Math.Max(maxSum, curSum);
        }
        
        return maxSum;
    }
}