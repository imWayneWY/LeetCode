/*
 * @lc app=leetcode id=73 lang=csharp
 *
 * [73] Set Matrix Zeroes
 */

// @lc code=start
public class Solution {
    public void SetZeroes(int[][] matrix) {
        List<int> xs = new List<int>();
        List<int> ys = new List<int>();

        for(int x =0; x<matrix.Length; x++) {
            for(int y=0; y<matrix[x].Length; y++) {
                if(matrix[x][y] == 0) {
                    if (xs.IndexOf(x) < 0) {
                        xs.Add(x);
                    }
                    if (ys.IndexOf(y) < 0) {
                        ys.Add(y);
                    }
                }
            }
        }
        // Console.Write(ys[1]);
        for(int x = 0; x<matrix.Length; x++) {
            for(int y=0; y<matrix[x].Length; y++) {
                if (xs.IndexOf(x) >= 0 || ys.IndexOf(y) >= 0) {
                    matrix[x][y] = 0;
                }
            }
        }
    }
}

// @lc code=end

