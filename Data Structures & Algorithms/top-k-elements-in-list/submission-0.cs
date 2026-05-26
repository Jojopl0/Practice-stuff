public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        PriorityQueue<int, int> minPQ = new PriorityQueue<int, int>();
        Dictionary<int, int> indexRate = new Dictionary<int, int>();
        int[] outP = new int[k];

        for (int i = 0; i < nums.Length; i++) {
            if (!indexRate.ContainsKey(nums[i])) {
                indexRate[nums[i]] = 1;
            }
            else {
                indexRate[nums[i]]++;
            }
        }
        foreach (var c in indexRate) {
            minPQ.Enqueue(c.Key, -c.Value);
        }
        for (int i = 0; i < k; i++) {
            outP[i] = minPQ.Dequeue();
        }
        return outP;
    }
}
