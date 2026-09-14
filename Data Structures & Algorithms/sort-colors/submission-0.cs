public class Solution {
    public void SortColors(int[] nums) {
        int[] arr = [0, 0, 0];
        int i = 0;
        for (i = 0; i < nums.Length; i++){
            arr[nums[i]]+=1;
        }

        i = 0;
        Console.Write("[");
        for (int j = 0; j < arr.Length; j++){
            for (int k = 0; k < arr[j]; k++){
                nums[i] = j;
                i+=1;
            }
        }
        Console.Write("]");

    }
}