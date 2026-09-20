public class Solution {
    public int PivotIndex(int[] nums) {
        int totalSum = 0;
        foreach (int num in nums) {
            totalSum += num;
        }
        
        int lSum = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (lSum == totalSum - lSum - nums[i]) {
                return i;
            }
            lSum += nums[i];
        }
        return -1;
    }
}