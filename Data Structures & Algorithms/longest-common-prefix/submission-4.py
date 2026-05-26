class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        d = {}
        largest = ""
        for str in strs:
            for i in range(0, len(str) + 1):
                temp = str[:i]
                if temp in d:
                    d[temp] += 1
                    if d[temp] == len(strs):
                        largest = temp
                else:
                    d[temp] = 1 
                    if d[temp] == len(strs):
                        largest = temp
        return largest
        