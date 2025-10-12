public class Solution {
    public int LengthOfLastWord(string s) {

        s = s.Trim();

        int lastSpace = s.LastIndexOf(' ');

        return s.Length - lastSpace - 1;
    }
}