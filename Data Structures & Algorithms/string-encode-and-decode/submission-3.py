class Solution:

    def encode(self, strs: List[str]) -> str:
        stored = ""
        curL = 0
        for v in strs:
            curL = len(v)
            stored += str(curL) + "a" + v
        return stored

    def decode(self, s: str) -> List[str]:
        master = []
        while (len(s) != 0):
            curInd = s.index('a')
            length = int(s[:curInd])
            word = s[curInd + 1:curInd + 1 + length]
            master.append(word)
            s = s[curInd + 1 + length:]
        return master
