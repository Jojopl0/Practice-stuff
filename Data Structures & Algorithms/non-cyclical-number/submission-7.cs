public class Solution {
    public bool IsHappy(int n) {
        HashSet<int>seen = new HashSet<int>();

        int temp = n;

        while (temp != 1) {
            int nTem = 0;
            while (temp > 0) {
                nTem += (int)Math.Pow((temp % 10), 2);
                temp /= 10;
            }
            if (seen.Contains(nTem)) {
                return false;
            }
            seen.Add(nTem);
            temp = nTem;
        }
        return true;


    }
}
