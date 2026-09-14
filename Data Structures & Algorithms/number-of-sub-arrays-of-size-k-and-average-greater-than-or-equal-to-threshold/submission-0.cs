public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int left = 0, right = 0, sum = 0, n = arr.Length, count = 0;
        if (n < k)
            return 0;
        
        while (right < n){
            sum += arr[right];
            right++;
            if (right - left > k){
                sum -= arr[left];
                left++;
            }
            if (right - left == k && sum/k >= threshold){
                count+=1;
            }
        }
        return count;
    }
}