public class Solution {
    int m, n;
    private int dfs(int[][] obstacleGrid, int r, int c, int[,] memo){
        if (r >= m || c >= n || obstacleGrid[r][c] == 1){
            return 0;
        }
        
        if (r == m - 1 && c == n - 1){
            return 1;
        }

        if (memo[r, c] != -1){
            return memo[r, c];
        }

        return memo[r,c] = dfs(obstacleGrid, r+1, c, memo) + dfs(obstacleGrid, r, c+1, memo);
    }

    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        m = obstacleGrid.Length;
        n = obstacleGrid[0].Length;

        int[,] memo = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                memo[i, j] = -1;
            }
        }
           
        return dfs(obstacleGrid, 0, 0, memo);
    }
}