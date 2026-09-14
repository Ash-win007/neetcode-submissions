public class Solution {
    public int OrangesRotting(int[][] grid) {
        int rn = grid.Length;
        int cn = grid[0].Length;


        Queue<(int row, int col)> q = new Queue<(int row, int col)>();
        int fresh = 0, minute = 0;

        for (int r = 0; r < grid.Length; r++) {
            for (int c = 0; c < grid[0].Length; c++) {
                if (grid[r][c] == 1) 
                    fresh++;
                else if (grid[r][c] == 2) 
                    q.Enqueue((r, c));
            }
        }

        if (fresh == 0)
            return 0;


        while (q.Count > 0){
            int size = q.Count;
            minute++;

            for (int i = 0; i < size; i++){
                var rot = q.Dequeue();

                (int r, int c)[] possible = {
                    (-1, 0),
                    (0, 1),
                    (1, 0),
                    (0, -1),
                };

                foreach (var element in possible){
                    if (element.r + rot.row > -1 && element.r + rot.row < rn
                        && element.c + rot.col > -1 && element.c + rot.col < cn
                        && grid[element.r + rot.row][element.c + rot.col] == 1){

                            q.Enqueue((element.r + rot.row, element.c + rot.col));
                            grid[element.r + rot.row][element.c + rot.col] = 2;
                            fresh--;

                        }
                    }
            
            }
            if (q.Count == 0){
                minute--;
            }
        }

        return fresh == 0 ? minute: -1;
    }
}

