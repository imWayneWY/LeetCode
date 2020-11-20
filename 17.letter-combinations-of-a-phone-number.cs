/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */

// @lc code=start
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        int len = digits.Length;
        if (len==0)
            return new string[0];
        char[][] keys = new char[8][] {
            new char[] {'a','b','c'},
            new char[] {'d','e','f'},
            new char[] {'g','h','i'},
            new char[] {'j','k','l'},
            new char[] {'m','n','o'},
            new char[] {'p','q','r','s'},
            new char[] {'t','u','v'},
            new char[] {'w','x','y','z'}
        };
        List<string> result = new List<string>();
        StringBuilder sb = new StringBuilder(len);
        LetterCombinations(digits, keys, 0, sb, result);
        return result;
    }

    private void LetterCombinations(string digits, char[][] keys, int keyIndex, StringBuilder sb, List<string> result) {
        if (sb.Length == digits.Length) {
            result.Add(sb.ToString());
            return;
        }
        if (keyIndex == digits.Length)
            return;
        foreach (char c in keys[digits[keyIndex] - '2']) {
            sb.Append(c);
            LetterCombinations(digits, keys, keyIndex+1, sb, result);
            sb.Remove(sb.Length-1, 1);
        }
    }
}
// @lc code=end

/*
    使用递归
    sb.Remove(sb.Length-1, 1); 是吧刚加上的最后一位删掉，循环下一次执行就可以取得新的可能值，sb就得到新的字符串
*/