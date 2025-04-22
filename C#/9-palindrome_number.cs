public class Solution {

    public bool IsPalindrome(int x) {
        
        String number = x.ToString();

        double halfLength = number.Length / 2;

        bool isEven = number.Length % 2 == 0;
    
        int remainNumbers = number.Length;
    
        for (int i = 0; i < halfLength; i++) {

            if (!isEven && remainNumbers < 3) {
                return true;
            }
            else if (number[i] != number[number.Length - i - 1]) {
                return false;
            }
            
            remainNumbers--;
        }
        
        return true;
    }
}