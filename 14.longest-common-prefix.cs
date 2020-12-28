/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length==0) return "";
        int shortestLength = strs[0].Length;
        string shortestWord = strs[0];
        for (int i = 1; i<strs.Length; i++) {
            if (strs[i].Length < shortestLength) {
                shortestLength = strs[i].Length;
                shortestWord = strs[i];
            }
        }

        int length = shortestLength;
        string result = "";

        // I didn't realize that it's prefix
        // for (int j=0; j<shortestLength; j++) {
        //     for (int k=0; k<shortestLength-length+1; k++) {
        //         bool itWorks = true;
        //         foreach(string word in strs) {
        //             if (!word.Contains(shortestWord.Substring(k, length))) {
        //                 itWorks = false;
        //                 break;
        //             }
        //         }
        //         if(itWorks) {
        //             result = shortestWord.Substring(k, length);
        //             break;
        //         }
        //     }
        //     if(result != "") break;
        //     length--;
        // }
        for (int j=0; j<shortestLength; j++) {
            bool itWorks = true;
            foreach(string word in strs) {
                if (word.IndexOf(shortestWord.Substring(0, length)) != 0) {
                    itWorks = false;
                    break;
                }
            }
            if(itWorks) {
                result = shortestWord.Substring(0, length);
                break;
            }
            if(result != "") break;
            length--;
        }
        return result;
    }
}
// @lc code=end

