public class Solution {
    int maxSize = 0;
    private int _rows, _cols;

    private int RecurseIsland(int[][] grid, int r, int c, int size){
        if (r >= _rows 
        || c >= _cols 
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
        _rows = grid.Length;
        _cols = grid[0].Length;
        for (int i = 0; i < _rows; i++){
            for (int j = 0; j < _cols; j++){
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
