public class Solution {
    int size;
    private int[] memo;
    private int dfs(int[] nums, int house){
        if (house >= size){
            return 0;
        }
        if (memo[house] != -1) {
            return memo[house];
        }

        return memo[house] = Math.Max(nums[house] + dfs(nums, house + 2), dfs(nums, house + 1));
    }

    public int Rob(int[] nums) {
        size = nums.Length;
        memo = new int[size];
        Array.Fill(memo, -1);
        return dfs(nums, 0);
    }
}
