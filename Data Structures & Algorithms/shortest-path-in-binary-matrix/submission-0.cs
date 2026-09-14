public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
        int distance = 1, n = grid[0].Length;

        if (grid[0][0] == 1)
            return -1;

        grid[0][0] = 1;
        queue.Enqueue((0, 0));
        
        while (queue.Count > 0){
            int size = queue.Count;
            for (int i = 0; i < size; i++){
                var (row, col) = queue.Dequeue();
                if ((row, col) == (n - 1, n - 1)){
                    return distance;
                }
                
                (int r, int c)[] possible =
                {
                    (-1, 0),
                    (-1, 1),
                    (0, 1),
                    (1, 1),
                    (1, 0),
                    (1, -1),
                    (0, -1),
                    (-1, -1)
                };

                foreach (var ele in possible){
                    if (row + ele.r < n && row + ele.r >= 0 
                        && col + ele.c < n && col + ele.c >= 0
                        && grid[row + ele.r][col + ele.c] == 0){
                            queue.Enqueue((row + ele.r, col + ele.c));
                            grid[row + ele.r][col + ele.c] = 1;
                    }
                }
            }
            distance++;
        }

        return -1;
    }
}