public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int r = 0; r < rows; r++) {
            // Quick check: is target possibly in this row?
            if (target < matrix[r][0] || target > matrix[r][cols - 1]) {
                continue;
            }

            int lo = 0, hi = cols - 1;

            while (lo <= hi) {
                int mid = lo + (hi - lo) / 2;

                if (matrix[r][mid] == target) {
                    return true;
                }

                if (matrix[r][mid] < target) {
                    lo = mid + 1;
                } else {
                    hi = mid - 1;
                }
            }
        }

        return false;
    }
}