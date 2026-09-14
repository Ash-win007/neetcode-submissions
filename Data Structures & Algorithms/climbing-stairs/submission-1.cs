public class Solution {
    public int ClimbStairs(int n) {
        int[] memo = new int[n + 1];
        return Climb(0, n, memo);
    }

    private int Climb(int currentSteps, int n, int[] memo) {
        if (currentSteps == n) return 1;
        if (currentSteps > n) return 0;
        if (memo[currentSteps] != 0) return memo[currentSteps];

        memo[currentSteps] = Climb(currentSteps + 1, n, memo) +
                             Climb(currentSteps + 2, n, memo);
        return memo[currentSteps];
    }
}