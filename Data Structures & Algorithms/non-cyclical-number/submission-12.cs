public class Solution {
    public bool IsHappy(int n) {

        int slow = n;
        int fast = calcNum(n);
        fast = calcNum(fast);

        while (slow != fast) {
            slow = calcNum(slow);
            fast = calcNum(fast);
            fast = calcNum(fast);

            
        }
        if (fast == 1) {
            return true;
        }
        return false;




    }

    private int calcNum(int n) {
        int tmp = 0;
        while (n > 0) {
            tmp += (int)Math.Pow((n % 10), 2);
            n /= 10;
        }
        return tmp;
    }
}
