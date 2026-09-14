public class Solution {
    int count = 0;
    List<List<int>> visited = new List<List<int>>();

    public void RecurseIsland(char[][] grid, int r, int c)
    {
        visited[r][c] = 1;
        if (r + 1 < grid.Length 
            && grid[r+1][c] == '1' 
            && visited[r+1][c] == 0)
        {
            RecurseIsland(grid, r + 1, c);
        }

        if (c + 1 < grid[0].Length 
            && grid[r][c + 1] == '1' 
            && visited[r][c + 1] == 0)
        {
            Console.Write("\nRight true at:r " + r + " c: " + c);
            RecurseIsland(grid, r, c + 1);
        }

        if (c - 1 > -1 
            && grid[r][c - 1] == '1' 
            && visited[r][c - 1] == 0)
        {
            RecurseIsland(grid, r, c - 1);
        }

        if (r - 1 > -1
            && grid[r - 1][c] == '1' 
            && visited[r - 1][c] == 0)
        {
            RecurseIsland(grid, r - 1, c);
        }
    }

    public int NumIslands(char[][] grid) {
        for (int i = 0; i < grid.Length; i++) {
            visited.Add(new List<int>());
            for (int j = 0; j < grid[0].Length; j++) {
                visited[i].Add(0);
            }
        }

        for (int i = 0; i < grid.Length; i++){
            for (int j = 0; j < grid[0].Length; j++){
                if (visited[i][j] == 0 && grid[i][j] == '1')    
                {
                    RecurseIsland(grid, i, j);
                    count += 1;
                    Console.Write("\nTrue start at: " + i + " j: " + j);
                } 

            }   
        }

        return count;
    }
}
