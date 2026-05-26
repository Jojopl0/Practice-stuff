public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s == "") {
            return 0;
        }
        int start = 0;
        int end = 0;
        int longestLength = 1;
        Dictionary<char, int> store = new Dictionary<char, int>();
        
        store[s[start]] = 1;

        while (end < s.Length) {
            if (end+1 >= s.Length) {
                break;
            }
            end++;
            if (!store.ContainsKey(s[end])) {
                store[(s[end])] = 1;
            }
            else {
                store[s[end]]++;
            }
            while (store[s[end]] > 1) {
                    store[s[start]]--;
                    start++;
                }
                longestLength = Math.Max(longestLength, end - start + 1);
        }
        return longestLength;

    }
}
