public class Solution {

    public int RemoveElement(int[] nums, int val) {
        
        int removedElements = 0;

        foreach (int n in nums) {

            if (n != val) {
                nums[removedElements] = n;
                removedElements++;
            }
        }

        return removedElements;
    }
}