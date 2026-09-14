public class Solution {
    public List<List<int>> res = new List<List<int>>();
    public HashSet<string> visited = new HashSet<string>();
    
    public void RecurseSubsets(int[] nums){
        string key = string.Join(",", nums);
        if (visited.Contains(key)) return;
        visited.Add(key);
        res.Add(nums.ToList());

        for (int i = 0; i < nums.Length; i++){
            var newArray = nums.Where((val, idx) => idx != i).ToArray();
            RecurseSubsets(newArray);
        }
    }

    public List<List<int>> Subsets(int[] nums) {
        RecurseSubsets(nums);
        return res;

    }
}
