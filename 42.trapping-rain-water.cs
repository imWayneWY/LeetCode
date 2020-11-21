/*
 * @lc app=leetcode id=42 lang=csharp
 *
 * [42] Trapping Rain Water
 */

// @lc code=start
public class Solution {
    public int Trap(int[] height) {
        if (height == null || height.Length == 0) {
            return 0;
        }
        int len = height.Length;
        int[] leftHeight = new int[len];
        int[] rightHeight = new int[len];
        int leftMax = 0;
        int rightMax= 0;
        int res = 0;

        for (int i= 0; i < len; i++) {
            leftMax = Math.Max(height[i], leftMax);
            leftHeight[i] = leftMax;
        }
        for (int j = len - 1; j >= 0; j--) {
            rightMax = Math.Max(rightMax, height[j]);
            rightHeight[j] = rightMax;
        }
        for (int k = 0; k < len; k++) {
            res += Math.Min(leftHeight[k], rightHeight[k]) - height[k];
        }
        return res;
    }
}
// @lc code=end

/*
    找到左右最高的高度，然后比较这两个中间最低的作为垂直的差值

    ** example:
     * height: 0,1,0,2,1,0,1,3,2,1,2,1
     * left:   0,1,1,2,2,2,2,3,3,3,3,3
     * right:  3,3,3,3,3,3,3,3,2,2,2,1
     * result: 0,0,1,0,1,2,1,0,0,1,0,0
     * answer: 6
*/