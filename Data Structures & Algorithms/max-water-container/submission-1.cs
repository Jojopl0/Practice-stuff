public class Solution {
    public int MaxArea(int[] heights) {
        int start = 0;
        int end = heights.Length - 1;  
        int minHeight = Math.Min(heights[start], heights[end]);
        
        int maxVolume = 0;
        while (start < end) {
            minHeight = Math.Min(heights[start], heights[end]);
            int checkVolume = ((end - start) * minHeight);
            maxVolume = Math.Max(checkVolume, maxVolume);
            if (heights[start] < heights[end]) {
                start++;
            }
            else {
                end--;
            }
        }
        return maxVolume;

    }
}
