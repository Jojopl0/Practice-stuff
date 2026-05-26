public class Solution {
    public int IslandPerimeter(int[][] grid) {
        //dfs
        //if not on the other side, then 
        int perim = 0;
        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                if (grid[i][j] == 1) {
                    //check up
                    if (i == 0) {
                        perim += 1;
                    }
                    else if (grid[i - 1][j] == 0) {
                        perim += 1;
                    }
                    //check down
                    if (i == grid.Length - 1) {
                        perim += 1;
                    }
                    else if (grid[i + 1][j] == 0) {
                        perim += 1;
                    }
                    //check right
                    if (j == grid[i].Length - 1) {
                        perim += 1;
                    }
                    else if (grid[i][j + 1] == 0) {
                        perim += 1;
                    }
                    //check left
                    if (j == 0) {
                        perim += 1;
                    }
                    else if (grid[i][j - 1] == 0) {
                        perim += 1;
                    }
                }
            }
        }
        return perim;
    }
}