public class Solution {
    public bool IsHappy(int n) {
        Dictionary<int, bool>seen = new Dictionary<int, bool>();

        int temp = n;

        while (temp != 1) {
            int nTem = 0;
            while (temp > 0) {
                nTem += (int)Math.Pow((temp % 10), 2);
                temp /= 10;
            }
            if (seen.ContainsKey(nTem)) {
                return false;
            }
            seen.Add(nTem, true);
            temp = nTem;
        }
        return true;


    }
}
