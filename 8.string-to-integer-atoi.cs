/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
using System.Text.RegularExpressions;
public class Solution {
    public int MyAtoi(string s) {
        Regex regex = new Regex(@"^(?<trail>((\s)+)*)((?<sign>(\+|-){1})?(?<number>\d+))?", RegexOptions.IgnoreCase);
        Match match = regex.Match(s);

        bool isNegative = match.Groups["sign"].Success && match.Groups["sign"].Value == "-";
        try
        {
            int result = match.Groups["number"].Success ?
                checked(int.Parse(match.Groups["number"].Value)) : 0;
            if (isNegative)
                result = -result;
            return result;
        }
        catch
        {
            return isNegative ? int.MinValue : int.MaxValue;
        }
    }
}
// @lc code=end

/* 正则表达式 */