public class Solution {
    public List<List<int>> res = new List<List<int>>();
    public List<int> numbers = new List<int>();
    public ISet<string> numberHash = new HashSet<string>();


    public void RecurseCombination(int currentSum, int[] nums, int target, int startIndex){
        if (currentSum == target) {
            List<int> sorted = new List<int>(numbers);
            sorted.Sort();
            string key = string.Join(", ", sorted);
            if (numberHash.Contains(key)){
                return;
            }
            numberHash.Add(key);
            res.Add(new List<int>(numbers));
            return;
        }

        for (int i = startIndex; i < nums.Length; i++){
            int num = nums[i] + currentSum;

            if (num <= target){
                numbers.Add(nums[i]);
                RecurseCombination(num, nums, target, i);
                numbers.RemoveAt(numbers.Count - 1);
            }
        }
    }

    public List<List<int>> CombinationSum(int[] nums, int target) {
        RecurseCombination(0, nums, target, 0);
        return res;
    }
}
