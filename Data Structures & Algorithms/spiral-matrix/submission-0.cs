public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        
        List<int> curList = new List<int>();

        if (matrix.Length == 0) {
            return curList;
        }


        int curTop = 0;
        int curBot = matrix.Length;
        int begInd = 0;
        int endInd = matrix[0].Length;

        while (curTop < curBot && begInd < endInd) {
            for (int i = begInd; i < endInd; i++) {
                curList.Add(matrix[curTop][i]);
            }
            curTop += 1;
            //go down on right
            for (int j = curTop ; j < curBot; j++) {
                curList.Add(matrix[j][endInd - 1]);
            }
            endInd -= 1;
            
            if (!(curTop < curBot && begInd < endInd)) break;

            //go backwards at bottom
            for (int k = endInd - 1; k >= begInd; k--) {
                curList.Add(matrix[curBot - 1][k]);
            }
            curBot -= 1;
            //go up on left
            for (int l = curBot - 1; l >= curTop; l--) {
                curList.Add(matrix[l][begInd]);
            }
            begInd += 1;
        }
        return curList;









    }
}
