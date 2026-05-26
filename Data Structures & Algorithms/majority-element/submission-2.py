class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        store = {}
        max = 0
        store[0] = 0
        for num in nums:
            if num in store:
                store[num] += 1
                if (store[num] > store[max]):
                    max = num
                if store[num] > (len(nums) / 2):
                    return num
            else:
                store[num] = 1
                if (store[num] > store[max]):
                    max = num
        return max