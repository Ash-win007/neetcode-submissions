public class Solution {

    private int[][] RecurseFill(int[][] image, int sr, int sc, int color, int initialColour, int r, int c, int[][] visited){
        if (sr < 0 
            || sr >= r 
            || sc < 0 
            || sc >= c
            || image[sr][sc] != initialColour
            || visited[sr][sc] == 1){
                return image;
        }

        image[sr][sc] = color;
        visited[sr][sc] = 1;
        
        RecurseFill(image, sr, sc + 1, color, initialColour, r, c, visited);
        
        RecurseFill(image, sr + 1, sc, color, initialColour, r, c, visited);
        
        RecurseFill(image, sr, sc - 1, color, initialColour, r, c, visited);
        
        RecurseFill(image, sr - 1, sc, color, initialColour, r, c, visited);

        return image;
    }


    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int r = image.Length;
        int c = image[0].Length;
        int[][] visited = new int[r][];
        for (int i = 0; i < r; i++) visited[i] = new int[c];
        RecurseFill(image, sr, sc, color, image[sr][sc], r, c, visited);
        return image;
    }
}