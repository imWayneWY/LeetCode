/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        char[] charArray = x.ToString().ToCharArray();
        int length = charArray.Length;
        bool result = true;
        for(int i=0; i<charArray.Length/2; i++) {
            if (charArray[i] != charArray[length-1-i]) {
                result=false;
                break;
            }
        }
        return result;
    }
}
// @lc code=end

/*
    Conver int to char array
    Judge if it's palindrom by array's index
*/