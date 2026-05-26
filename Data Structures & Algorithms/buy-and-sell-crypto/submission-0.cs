public class Solution {
    public int MaxProfit(int[] prices) {
        int minBuy = prices[0];
        int maxSell = 0;

        for (int i = 1; i < prices.Length; i++) {
            maxSell = Math.Max(maxSell, prices[i] - minBuy);
            
            if (prices[i] < minBuy) {
                minBuy = prices[i];
            }
        }
        return maxSell;
    }
}
