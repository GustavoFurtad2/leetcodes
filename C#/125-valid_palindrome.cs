public class Solution {

    public bool IsPalindrome(string s) {
        
        String formatedString = "";

        for (int i = 0; i < s.Length; i++) {

            char currentChar = s[i];

            if (currentChar >= 'A' && currentChar <= 'Z'
                || currentChar >= 'a' && currentChar <= 'z'
                || currentChar >= '0' && currentChar <= '9') {

                if (currentChar >= 'A' && currentChar <= 'Z') {
                    
                    currentChar = (char)(currentChar + 32);
                }

                formatedString += currentChar;
            }
        }

        double halfLength = formatedString.Length / 2;

        bool isEven = formatedString.Length % 2 == 0;
    
        int remainCharacters = formatedString.Length;
    
        for (int i = 0; i < halfLength; i++) {

            if (!isEven && remainCharacters < 3) {
                return true;
            }
            else if (formatedString[i] != formatedString[formatedString.Length - i - 1]) {
                return false;
            }
            
            remainCharacters--;
        }
        
        return true;
    }
}