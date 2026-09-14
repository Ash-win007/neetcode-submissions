public class Solution {
    private int _rows, _cols;
    
    public int MaxAreaOfIsland(int[][] grid) {
        _rows = grid.Length;
        _cols = grid[0].Length;
        int maxSize = 0;
        
        for (int i = 0; i < _rows; i++) {
            for (int j = 0; j < _cols; j++) {
                if (grid[i][j] == 1) {
                    maxSize = Math.Max(maxSize, Dfs(grid, i, j));
                }
            }
        }
        return maxSize;
    }
    
    private int Dfs(int[][] grid, int r, int c) {
        // Check bounds and value in one go
        if (r < 0 || r >= _rows || c < 0 || c >= _cols || grid[r][c] == 0) 
            return 0;
            
        grid[r][c] = 0;  // Mark as visited
        
        // No need to thread size through — just return 1 + sum of neighbors
        return 1 + Dfs(grid, r+1, c) + Dfs(grid, r-1, c) + 
                   Dfs(grid, r, c+1) + Dfs(grid, r, c-1);
    }
}