public class Solution {

    public string Encode(IList<string> strs) {
        string cur = "";
        int curL = 0;
        foreach (var current in strs) {
            int tCL = current.Length;
            string tS = current;
            Console.Write(tCL);
            cur += tCL.ToString() + 'a' + tS;
            Console.Write(cur);
        }
        Console.Write(cur);
        return cur;
    }

    public List<string> Decode(string s) {
        List<string> uncoded = new List<string>();
        while (!string.IsNullOrEmpty(s)) {
            int limit = s.IndexOf('a');
            int wLength = int.Parse(s.Substring(0,limit));
            string tWord = s.Substring(limit + 1, wLength);
            uncoded.Add(tWord);
            s = s.Substring(limit + wLength + 1);
        }
        return uncoded;
   }
}
