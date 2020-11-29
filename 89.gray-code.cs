/*
 * @lc app=leetcode id=89 lang=csharp
 *
 * [89] Gray Code
 */

// @lc code=start
public class Solution {
    public IList<int> GrayCode(int n) {
        List<int> res = new List<int>();
        res.Add(0);
        for (int i=0; i < n; i++) {
            List<int> temp = new List<int>(res);
            for (int j = temp.Count - 1; j >= 0; j--) {
                res.Add((1 << i) | temp[j]);
            }
        }
        return res;
    }
}
// @lc code=end

