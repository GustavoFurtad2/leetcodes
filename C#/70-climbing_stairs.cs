public class Solution {

    public int ClimbStairs(int n) {

        if (n <= 0) {
            return 0;
        }
        else if (n == 1) {
            return 1;
        }

        int a = 0;
        int b = 1;
        int c;

        for (int i = 0; i < n; i++) {

            c = a + b;
            a = b;
            b = c;
        }

        return b;
    }
}