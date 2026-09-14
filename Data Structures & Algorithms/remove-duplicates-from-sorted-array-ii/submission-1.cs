public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int left = 0, right = 0, n = nums.Length, curSize = n, i = 0;

        if (n == 1)
            return 1;
    //[0,0,1,1,1,1,2,3,3]   
        while (right < curSize){
            while (right < curSize && nums[left] == nums[right]){
                right++;
            }
            if (right - left <= 2){
                left = right;
                right = right + 1;
            }
            else{
                left += 2;
                int startIndex = left;
                curSize = curSize - (right - left);
                while (startIndex <= n && right < n){
                    nums[startIndex++] = nums[right++];
                }
                right = left + 1;
            }

            Console.Write("\n r: " + right);
            Console.Write("\n l: " + left);
            Console.Write("\n s: " + curSize + "\n");
            for (i = 0; i < n; i++){
                Console.Write(nums[i] + " , ");
            }

        }

        return curSize;
    }
}