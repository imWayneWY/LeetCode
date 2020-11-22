/*
 * @lc app=leetcode id=48 lang=csharp
 *
 * [48] Rotate Image
 */

// @lc code=start
public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        for (int b = 0; b < n/2; b++) {
            for (int i = b; i < (n-1)-b; i++) {
                int tl = matrix[b][i];
                matrix[b][i] = matrix[(n-1)-i][b];
                matrix[(n-1)-i][b] = matrix[(n-1)-b][(n-1)-i];
                matrix[(n-1)-b][(n-1)-i] = matrix[i][(n-1)-b];
                matrix[i][(n-1)-b] = tl;
            }
        }
    }
}
// @lc code=end

