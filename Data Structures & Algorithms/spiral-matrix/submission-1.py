class Solution:
    def spiralOrder(self, matrix: List[List[int]]) -> List[int]:
        res = []
        topInd = 0
        leftInd = 0
        bottomInd = len(matrix)
        rightInd = len(matrix[0])

        while (topInd < bottomInd and leftInd < rightInd):
            for i in range(leftInd, rightInd):
                res.append(matrix[topInd][i])
            topInd += 1
            for i in range(topInd, bottomInd):
                res.append(matrix[i][rightInd - 1])
            rightInd -= 1

            if topInd == bottomInd or rightInd == leftInd:
                break;

            for i in range(rightInd - 1, leftInd - 1, -1):
                res.append(matrix[bottomInd - 1][i])
            bottomInd -= 1
            for i in range(bottomInd - 1, topInd - 1, -1):
                res.append(matrix[i][leftInd])
            leftInd += 1
        return res
