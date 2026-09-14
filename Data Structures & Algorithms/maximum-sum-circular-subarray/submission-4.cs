public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int n = nums.Length;
        int totalSum = 0;
        int curMax = 0, maxSum = nums[0];
        int curMin = 0, minSum = nums[0];

        for (int i = 0; i < n; i++) {
            int x = nums[i];
            curMax = Math.Max(x, curMax + x);
            maxSum = Math.Max(maxSum, curMax);
            curMin = Math.Min(x, curMin + x);
            minSum = Math.Min(minSum, curMin);
            totalSum += x;
        }

        return maxSum > 0 ? Math.Max(maxSum, totalSum - minSum) : maxSum;
    }
}