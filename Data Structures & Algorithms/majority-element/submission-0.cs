public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> store = new Dictionary<int, int>();
        int max = 0;
        store[0] = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (store.ContainsKey(nums[i])) {
                store[nums[i]]++;
                if ((store[nums[i]]) > (nums.Length / 2)) {
                    return nums[i];
                }
                if (store[nums[i]] > store[max]) {
                    max = nums[i];
                }
            }
            else {
                store[nums[i]] = 1;
                if (store[nums[i]] > store[max]) {
                    max = nums[i];
                }
            }
        }
        return max;
    }
}