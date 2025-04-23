public class Solution {

    public int SearchInsert(int[] nums, int target) {

        int arrow = nums.Length / 2;
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            
            arrow = left + (right - left) / 2;

            if (nums[arrow] == target) {
                return arrow;
            }
            else if (nums[arrow] < target) {
                left = arrow + 1;
            }
            else {
                right = arrow - 1;
            }
        }

        return left;
    }
}