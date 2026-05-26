public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        String longest = "";
        for (int i = 0; i < strs.Length; i++) {
            for (int j = 0; j <= strs[i].Length; j++) {
                String temp = strs[i].Substring(0, j);
                if (dict.ContainsKey(temp)) {
                    dict[temp] += 1;
                    if (dict[temp] == strs.Length) {
                        longest = temp;
                    }
                }
                else {
                    dict[temp] = 1;
                    if (dict[temp] == strs.Length) {
                        longest = temp;
                    }
                }
            }
        }
        return longest;
    }
}