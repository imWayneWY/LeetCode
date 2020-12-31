/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 0;
        List<int> res = new List<int>();
        for (int i=digits.Length-1; i>=0; i--) {
            int u = digits[i] + carry;
            if (i == digits.Length-1) u++;
            if (u > 9) {
                u = 0;
                carry = 1;
            } else {
                carry = 0;
            }            
            res.Add(u);
        }
        if (carry==1) res.Add(1);
        res.Reverse();
        return res.ToArray();
    }
}
// @lc code=end

