public class Solution {
    int maxSize = 0;

    private int RecurseIsland(int[][] grid, int r, int c, int size){
        if (r >= grid.Length 
        || c >= grid[0].Length 
        || r < 0
        || c < 0
        || grid[r][c] == 0){
            return size;
        }
        size += 1;
        grid[r][c] = 0;
        size = RecurseIsland(grid, r + 1, c, size);
        size = RecurseIsland(grid, r - 1, c, size);
        size = RecurseIsland(grid, r, c + 1, size);
        size = RecurseIsland(grid, r, c - 1, size);

        return size;
    }

    public int MaxAreaOfIsland(int[][] grid) {
        for (int i = 0; i < grid.Length; i++){
            for (int j = 0; j < grid[0].Length; j++){
                if (grid[i][j] != 0){
                    int size = RecurseIsland(grid, i, j, 0);
                    if (maxSize < size){
                        maxSize = size;
                    }
                }
            }
        }

        return maxSize;
    }
}
