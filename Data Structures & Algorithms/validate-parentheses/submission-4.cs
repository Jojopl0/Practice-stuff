public class Solution {
    public bool IsValid(string s) {
        Stack<int> cur = new Stack<int>();

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[') {
                cur.Push(s[i]);
            }
            else if (s[i] == ')') {
                if (cur.Count() != 0 && cur.Peek() == '(') {
                    cur.Pop();
                }
                else {
                    return false;
                }
            }
            else if (s[i] == '}') {
                if (cur.Count() != 0 && cur.Peek() == '{') {
                    cur.Pop();
                }
                else {
                    return false;
                }
            }
            else if (s[i] == ']') {
                if (cur.Count() != 0 && cur.Peek() == '[') {
                    cur.Pop();
                }
                else {
                    return false;
                }
            }
        }
        if (cur.Count() != 0) {
            return false;
        }
        else {
            return true;
        }
    }
}
