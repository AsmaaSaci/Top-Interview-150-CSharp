public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1;
        long exp = n;
        if (exp < 0) {
            x = 1 / x;
            exp = -exp;
        }
        double result = 1;
        while (exp > 0) {
            if ((exp & 1) == 1) result *= x;
            x *= x;
            exp >>= 1;
        }
        return result;
    }
}
