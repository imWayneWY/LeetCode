/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> roma = new Dictionary<char, int>(){
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        char[] charArray = s.ToString().ToCharArray();
        int prev = roma[charArray[0]];
        int result = prev;
        for (int i=1; i<charArray.Length; i++) {
            int curr = roma[charArray[i]];
            int tmp = 0;
            
            if (prev >= curr) {
                tmp += curr;
            } else {
                tmp = curr - 2 * prev;
            }
            prev = curr;
            result += tmp;
        }
        return result;
    }
}
// @lc code=end

