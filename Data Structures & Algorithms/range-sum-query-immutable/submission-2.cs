public class NumArray {

    public int[] numbers;
    public NumArray(int[] nums) {
        numbers = nums;
    }
    
    public int SumRange(int left, int right) {
        int total = 0;
        while (left <= right){
            total += numbers[left++];
        }

        return total;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */