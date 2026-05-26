public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int jump = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == val) {
                jump +=1;
            }
            else {
                nums[i - jump] = nums[i];
            }
        }
        return nums.Length - jump;
    }
}