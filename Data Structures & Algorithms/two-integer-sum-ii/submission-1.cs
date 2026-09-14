public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0, right = numbers.Length - 1;

        while(true){
            if (numbers[left] + numbers[right] == target)
                return [left + 1, right + 1];
            
            if (numbers[left] + numbers[right] > target)
                right--;
            else
                left++;
        }
    }
}
