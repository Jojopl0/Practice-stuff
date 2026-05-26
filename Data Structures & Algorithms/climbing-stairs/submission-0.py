class Solution:
    def climbStairs(self, n: int) -> int:

        if (n < 2):
            return 1
        if (n < 3):
            return 2
        
        listt = [0] * n;
        listt[0] = 1
        listt[1] = 2

        for i in range(2, n):
            listt[i] = listt[i - 1] + listt[i - 2]
        
        return listt[n - 1]
