public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans = nums.Concat(nums).ToArray();
        return ans;
    }
}