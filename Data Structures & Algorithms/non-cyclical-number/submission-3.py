class Solution:
    def isHappy(self, n: int) -> bool:
        seen = {}
        temp = n

        while (temp != 1):
            curT = 0
            while (temp > 0):
                curT += (temp % 10) ** 2
                temp //= 10
            if curT in seen:
                return False
            seen[curT] = True
            temp = curT
        return True
