public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> discovered = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (discovered.Contains(nums[i])) {
                return true;
            }
            else {
                discovered.Add(nums[i]);
            }
        }
        return false;
    }
}