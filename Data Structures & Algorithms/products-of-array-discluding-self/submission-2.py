class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        products = [1]*len(nums)
        pre = [1]*len(nums)
        pre[0] = nums[0]
        suf = [1]*len(nums)
        suf[len(nums) - 1] = nums[len(nums) - 1]
        for i in range(1,len(nums)):
            pre[i] = pre[i - 1] * nums[i]
        for i in range(len(nums) - 2, 0, -1):
            suf[i] = suf[i + 1] * nums[i]

        products[0] = suf[1]
        products[len(nums) - 1] = pre[len(nums) - 2]
        for i in range(1, len(nums) - 1):
            products[i] = pre[i - 1] * suf[i + 1]
        return products