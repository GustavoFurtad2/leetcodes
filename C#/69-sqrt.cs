public class Solution {

    public int MySqrt(int x) {
        
        long number = 0;

        while (number * number <= x) {

            number++;       
        }
        
        return (int)(number - 1);
    }
}