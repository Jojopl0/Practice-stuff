public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> outP = new List<List<int>>();
        Array.Sort(nums);
        int leftWind;
        int rightWind;

        for (int i = 0; i < nums.Length; i++) {
            leftWind = i + 1;
            rightWind = nums.Length - 1;
            if (i > 0 && nums[i] == nums[i - 1]){
                continue;
            }
            while (leftWind < rightWind) {
                int sum = nums[i] + nums[leftWind] + nums[rightWind];
                if (sum == 0) {
                    outP.Add(new List<int> {nums[i], nums[leftWind], nums[rightWind]});
                    while (leftWind < rightWind && nums[leftWind] == nums[leftWind + 1]){
                        leftWind++;
                    }
                    while (leftWind < rightWind && nums[rightWind] == nums[rightWind - 1]){
                        rightWind--;
                    }
                    leftWind++;
                    rightWind--;
                }
                else if (sum < 0) {
                    leftWind++;
                }
                else {
                    rightWind--;
                }
                
            }
        }
        return outP;
    }
}
