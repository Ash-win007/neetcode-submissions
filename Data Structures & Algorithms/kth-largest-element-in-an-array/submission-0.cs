public class Solution {
public int FindKthLargest(int[] nums, int k)
{
    int target = nums.Length - k;

    int left = 0;
    int right = nums.Length - 1;

    while (true)
    {
        int pivotIndex = Partition(nums, left, right);

        if (pivotIndex == target)
            return nums[pivotIndex];

        if (pivotIndex < target)
            left = pivotIndex + 1;
        else
            right = pivotIndex - 1;
    }
}

private int Partition(int[] nums, int left, int right)
{
    int pivot = nums[right];

    int i = left;

    for (int j = left; j < right; j++)
    {
        if (nums[j] <= pivot)
        {
            (nums[i], nums[j]) = (nums[j], nums[i]);
            i++;
        }
    }

    (nums[i], nums[right]) = (nums[right], nums[i]);

    return i;
}
}
