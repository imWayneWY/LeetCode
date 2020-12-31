/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        bool isCounting = false;
        for (int i = s.Length-1; i>=0; i--) {
            if (s[i] != ' ') {
                isCounting = true;
                count++;
                continue;
            }
            if (isCounting) {
                if (s[i] == ' ') {
                    break;
                } else {
                    count++;
                }
            }
        }
        return count;
    }
}
// @lc code=end

