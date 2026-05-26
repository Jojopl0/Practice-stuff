public class Solution {
    public bool IsPalindrome(string s) {
        var front = 0;
        var end = s.Length - 1;

        while (front < end) {
            while (front < end && !char.IsLetterOrDigit(s[front])) {
                front++;
            }
            while (front < end && !char.IsLetterOrDigit(s[end])) {
                end--;
            }
            if (char.ToLower(s[front]) != char.ToLower(s[end])) {
                return false;
            }
            front++;
            end--;
        }
        return true;
        
    }
}
