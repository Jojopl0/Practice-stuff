class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        jump = 0
        for i in range(0, len(nums)):
            if nums[i] == val:
                jump+=1
            else:
                nums[i - jump] = nums[i]
        return len(nums) - jump