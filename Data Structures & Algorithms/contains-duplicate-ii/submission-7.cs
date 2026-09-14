public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int left = 0, right = 0, n = nums.Length;
        HashSet<int> set = new HashSet<int>();
        while (right < n){
            if (set.Contains(nums[right])){
                return true;
            }

            if (right - left <= k){
                set.Add(nums[right]);
                right++;
            }

            if (right - left > k){
                set.Remove(nums[left]);
                left++;
            }
        }

        return false;
    }
}