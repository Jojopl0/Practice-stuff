public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var beg = 0;
        var end = numbers.Length - 1;
        var curVal = (numbers[beg] + numbers[end]);
        int[] outP = new int[2];

        while (curVal != target && beg < end) {
            if (curVal > target) {
                end--;
                curVal = (numbers[beg] + numbers[end]);
            }
            else if (curVal < target) {
                beg++;
                curVal = (numbers[beg] + numbers[end]);
            }
        }
        outP[0] = beg + 1;
        outP[1] = end + 1;
        return outP;
    }
}
