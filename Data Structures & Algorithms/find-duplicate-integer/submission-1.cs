public class Solution {
    public int FindDuplicate(int[] nums) {
    int lo = 1, hi = nums.Length - 1;
    while (lo < hi) {
        int mid = lo + (hi - lo) / 2;
        int count = 0;
        foreach (int x in nums) if (x <= mid) count++;
        if (count > mid) hi = mid;   // duplicate is <= mid
        else lo = mid + 1;           // duplicate is > mid
    }
    return lo;
}
}