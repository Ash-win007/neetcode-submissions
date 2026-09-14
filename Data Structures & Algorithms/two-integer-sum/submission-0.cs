public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++){
            var need = target - nums[i];
            if (dict.TryGetValue(need, out int val)){
                return new int[] { val, i };
            }
            else{
                dict[nums[i]] = i;
            }
        }
        return nums;
    }
}
