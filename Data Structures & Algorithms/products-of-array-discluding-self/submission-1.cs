public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] products = new int[nums.Length];
        int[] pre = new int[nums.Length];
        pre[0] = nums[0];
        int[] suf = new int[nums.Length];
        suf[nums.Length - 1] = nums[nums.Length - 1];
        for (int i = 1; i < nums.Length; i++) {
            pre[i] = nums[i] * pre[i - 1];
            //Console.WriteLine(pre[i]);
        }
        //Console.WriteLine("break");
        for (int i = nums.Length - 2; i >= 0; i--) {
            suf[i] = suf[i + 1] * nums[i];
            //Console.WriteLine(suf[i]);
        }
        products[0] = suf[1];
        products[nums.Length - 1] = pre[nums.Length - 2];
        for (int i = 1; i < nums.Length - 1; i++) {
            products[i] = pre[i - 1] * suf[i + 1];
        }
        return products;
    }
}
