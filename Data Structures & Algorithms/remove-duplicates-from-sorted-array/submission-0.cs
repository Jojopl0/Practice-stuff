public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var curpos = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[curpos] = nums[i];
                curpos++;
            } 
        }
        return curpos;
    }
}