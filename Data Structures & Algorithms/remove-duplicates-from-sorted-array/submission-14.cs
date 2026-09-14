public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;

        if (n == 1)
            return 1;

        int k = 1, left = 0, right = 1;

        while (right < n){

            while (right + 1 < n && nums[left] >= nums[left + 1]){
                nums[left + 1] = nums[right + 1];
                right++;
            }
            
            if (nums[left] != nums[left + 1]){
                left++;
                right = right > left ? right : left;
                k++;
            }

            if (right == n - 1)
                break;

            Console.Write("\nLeft: " + left);
            Console.Write("\nVal: " + nums[left]);

            Console.Write("\nRight: " + right);
            Console.Write("\nVal: " + nums[left + 1]);

            Console.Write("\nK: " + k);
            Console.Write("\n");

        }

        return k;
    }
}