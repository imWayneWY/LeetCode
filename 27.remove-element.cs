/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int length = nums.Length;

        for (int i = nums.Length-1; i>=0; i--) {
            if (nums[i] == val) {
                length--;
                nums[i] = nums[length];
            }
        }
        return length;
    }
}
// @lc code=end

/*
把最后一位的值拿到要remove的位置上
*/