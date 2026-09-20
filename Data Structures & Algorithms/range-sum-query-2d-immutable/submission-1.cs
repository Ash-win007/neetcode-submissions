public class NumMatrix {
    public int[][] mat;
    public NumMatrix(int[][] matrix) {
        mat = matrix;
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int total = 0;
        for (int i = row1; i <= row2; i++){
            for (int j = col1; j <= col2; j++){
                total += mat[i][j];
            }
        }
        return total;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */