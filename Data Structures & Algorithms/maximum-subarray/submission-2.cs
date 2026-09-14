public class Solution {
    public int MaxSubArray(int[] nums) {
        int curSum = 0, maxSum = int.MinValue;
        int max = nums.Max();
        if (max < 0){
            return max;
        }
        
        foreach (var n in nums){
            curSum = Math.Max(curSum + n, 0);
            maxSum = Math.Max(curSum, maxSum);
        }

        return maxSum;
    }
}
