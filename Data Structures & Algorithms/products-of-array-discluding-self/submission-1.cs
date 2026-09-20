public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int totalSum = 1;
        int zeroCount = 0;
        foreach (int num in nums){
            if (num != 0)
                totalSum *= num;
            else
                zeroCount++;
        }
        for (int i = 0; i < nums.Length; i++){
            if (zeroCount > 1)
                nums[i] = 0;
            else if (zeroCount == 1)
                nums[i] = nums[i] == 0 ? totalSum : 0;
            else
                nums[i] = totalSum / nums[i];
        }

        return nums;
    }
}
