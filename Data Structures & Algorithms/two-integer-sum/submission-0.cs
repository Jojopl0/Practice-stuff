public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> storeInd = new Dictionary<int, int>();
        int[] outP = {0, 0};
        
        for (int i = 0; i < nums.Length; i++) {
            
            int checkFor = target - nums[i];
            if (storeInd.ContainsKey(checkFor)) {
                outP[0] = (storeInd[checkFor]);
                outP[1] = i;
                return outP;
            }
            storeInd[nums[i]] = i;
        }
        return outP;
    }
}
