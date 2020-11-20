/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        // Get ready initial state (enforce element type)
        var k = new Stack<char>();
        // Evaluate each character for potential mismatch
        foreach(char c in s) {
            // Push closing bracket onto the stack
            if (c == '(') { k.Push(')'); continue; }
            if (c == '[') { k.Push(']'); continue; }
            if (c == '{') { k.Push('}'); continue; }
            // Look out for imbalanced strings or mismatches
            if (k.Count==0 || c!=k.Pop()) return false;
        }
        // Empty stack means string is valid and invalid otherwise
        return k.Count == 0;
    }
}
// @lc code=end

