/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Implement strStr()
 */

// @lc code=start
public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle == "" || haystack==needle) return 0;
        char[] hay = haystack.ToCharArray();
        char[] nee = needle.ToCharArray();
        int length = nee.Length;
        int res = -1;
        for (int i=0; i<(haystack.Length-length+1); i++) {
            bool itWorks = true;
            for (int j=0; j<length; j++) {
                if (hay[i+j]!=nee[j]) {
                    itWorks = false;
                    break;
                }
            }
            if (itWorks) {
                res = i;
                break;
            }
        }
        return res;
    }
}
// @lc code=end

