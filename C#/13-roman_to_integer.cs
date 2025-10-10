public class Solution {
    public int RomanToInt(string s) {
        
        int output = 0;
        bool skip = false;

        for (int i = 0; i < s.Length; i++) {

            if (skip == true) {

                skip = false;

                continue;
            }

            if (i + 1 < s.Length) {

                if (s[i] == 'I' && s[i + 1] == 'V') {

                    output += 4;

                    skip = true;

                    continue;
                }
                else if (s[i] == 'I' && s[i + 1] == 'X') {

                    output += 9;

                    skip = true;

                    continue;
                }
                else if (s[i] == 'X' && s[i + 1] == 'L') {

                    output += 40;

                    skip = true;

                    continue;
                }
                else if (s[i] == 'X' && s[i + 1] == 'C') {

                    output += 90;

                    skip = true;

                    continue;
                }
                else if (s[i] == 'C' && s[i + 1] == 'D') {

                    output += 400;

                    skip = true;

                    continue;
                }
                else if (s[i] == 'C' && s[i + 1] == 'M') {

                    output += 900;

                    skip = true;

                    continue;
                }
            }

            switch (s[i]) {

                case 'I':

                    output++;

                    break;

                case 'V':

                    output += 5;

                    break;

                case 'X':

                    output += 10;

                    break;

                case 'L':

                    output += 50;

                    break;

                case 'C':

                    output += 100;

                    break;

                case 'D':

                    output += 500;

                    break;

                case 'M':

                    output += 1000;

                    break;
            }
        }

        return output;
    }
}