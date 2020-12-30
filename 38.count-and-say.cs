/*
 * @lc app=leetcode id=38 lang=csharp
 *
 * [38] Count and Say
 */

// @lc code=start
public class Solution {
    public string CountAndSay(int n) {
        if (n==1) return "1";
        string str = CountAndSay(n-1);
        string result = "";
        char curr = str[0];
        int count = 0;
        for (int i=0; i<str.Length; i++) {
            if (str[i] != curr) {
                result += count.ToString() + curr.ToString();
                curr = str[i];
                count = 1;
            } else {
                count++;
            }
            if (i==str.Length-1) result += count.ToString() + curr.ToString();
        }
        return result;
    }
}
// @lc code=end

