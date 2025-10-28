/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* twoSum(int* nums, int numsSize, int target, int* returnSize) {
    
    *returnSize = 2;
    int* output = malloc(sizeof(int) * 2);

    for (int i = 0; i < numsSize; i++) {

        for (int j = i + 1; j < numsSize; j++) {

            if (nums[i] + nums[j] == target) {

                output[0] = i;
                output[1] = j;

                return output;
            }
        }
    }

    *returnSize = 0;
    return NULL;
}