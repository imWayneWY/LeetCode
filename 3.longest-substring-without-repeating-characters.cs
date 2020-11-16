/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var maxlen = 0;
        var lastIndexByChar = Enumerable.Repeat(-1, 128).ToArray();

        for (int i =0, start = -1; i< s.Length; i++)
        {
            var c = (int)s[i];
            start = Math.Max(start, lastIndexByChar[c]);
            maxlen = Math.Max(maxlen, i-start);
            lastIndexByChar[c] = i;
        }
        return maxlen;
    }
}
// @lc code=end

/*
    lastIndexByChar存储一个char类型字符在字符串中的index
    遍历字符串，把字符串当前下标的字符转为int
    start：起始位置是这个char上次出现的下标
    当前坐标减start就是无重复字符长度
    maxlen存储最长的长度
*/
