public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> outP = new List<List<string>>();
        Dictionary<string, List<string>> anaGroups = new Dictionary<string, List<string>>();
        
        for (int i = 0; i < strs.Length; i++) {
            char[] copy = strs[i].ToCharArray();
            Array.Sort(copy);
            string sorted = new string(copy);
            if (!anaGroups.ContainsKey(sorted)) {
                anaGroups[sorted] = new List<string>();
            }
            anaGroups[sorted].Add(strs[i]);
        }

        foreach (var c in anaGroups) {
            outP.Add(c.Value);
        }

        return outP;
    }
}
