public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0, totalSum = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict[0] = 1;

        foreach (int num in nums){
            totalSum += num;
            if (dict.TryGetValue(totalSum - k, out int val)){
                count += val;
            }

            if (dict.TryGetValue(totalSum, out int freq)){
                dict[totalSum] = freq + 1;
            }
            else{
                dict[totalSum] = 1;
            }
        }
        return count;

    }
}