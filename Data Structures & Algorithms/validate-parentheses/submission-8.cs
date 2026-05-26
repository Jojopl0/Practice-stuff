public class Solution {
    public bool IsValid(string s) {
        Stack<char> curStr = new Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            char cur = s[i];
            if (cur == '(' || cur == '{' || cur == '[') {
                curStr.Push(cur);
            }
            else if (curStr.Count < 1) {
                return false;
            }

            else if (cur == ')' && curStr.Peek() == '(') {
                curStr.Pop();
            } 
            else if (cur == '}' && curStr.Peek() == '{') {
                curStr.Pop();
            }
            else if (cur == ']' && curStr.Peek() == '[') {
                curStr.Pop();
            }
            else {
                return false;
            }
        }

        if (curStr.Count == 0) {
            return true;
        } 
        return false;
    }
}
