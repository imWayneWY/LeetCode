/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {
        if (x >= Int32.MaxValue || x <= Int32.MinValue) return 0;
        bool isNegative = x < 0;
        char[] charArray = Math.Abs(x).ToString().ToCharArray();
        Array.Reverse(charArray);
        long result = long.Parse(new string(charArray));
        if (result >= Int32.MaxValue || 0 - result <= Int32.MinValue) return 0;
        if (isNegative) result = 0 - result;
        return (int)result;
    }
}
// @lc code=end

/**
    Judge if input is valid for Int32
    Record if input is negative
    Convert the input to string and reverse
    Judge if result is valid for Int32
    Set if input is negative
    Output
**/

