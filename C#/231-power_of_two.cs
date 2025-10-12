public class Solution {
    public bool IsPowerOfTwo(int n) {
        
        if (n <= 0) {

            return false;
        }

        int exponent = 0;

        while (true) {

            double power = Math.Pow(2, exponent);

            if (power == n) {

                return true;
            }

            if (power > n) {

                return false;
            }

            exponent++;
        }
    }
}