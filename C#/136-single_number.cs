public class Solution {

    public int SingleNumber(int[] nums) {
        
        Dictionary<int, int> map = new Dictionary<int, int>();

        foreach (int num in nums) {

            map[num] = map.ContainsKey(num) ? 1 : 0;
        }

        foreach (KeyValuePair<int, int> item in map) {

            if (item.Value == 0) {
                return item.Key;
            }
        }

        return 0;
    }
}