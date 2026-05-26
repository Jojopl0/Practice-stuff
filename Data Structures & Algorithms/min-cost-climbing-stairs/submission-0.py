class Solution:
    def minCostClimbingStairs(self, cost: List[int]) -> int:
        minCost = [0] * (len(cost));
        minCost[0] = cost[0]
        minCost[1] = cost[1]

        for i in range(2, len(cost)):
            c1 = minCost[i - 1]
            c2 = minCost[i - 2]
            minCost[i] = cost[i] + min(c1, c2)
        return min(minCost[len(cost) - 1], minCost[len(cost) - 2])

        