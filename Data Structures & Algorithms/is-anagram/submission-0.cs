public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        Dictionary<char, int> charStore = new Dictionary<char, int>();

        foreach (char ch in s) {
            charStore[ch] = charStore.GetValueOrDefault(ch, 0) + 1;
        }
        foreach (char ch in t) {
            charStore[ch] = charStore.GetValueOrDefault(ch, 0) - 1;
        }

        foreach (var v in charStore) {
            if (v.Value != 0) {
                return false;
            }
        }
        return true;



    }
}
