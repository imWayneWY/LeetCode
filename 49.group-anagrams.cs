/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
		=> strs
			.Select(s => (val: s, sorted: String.Concat(s.OrderBy(c => c))))
			.GroupBy(st => st.sorted, st => st.val)
			.Select(g => g.ToList() as IList<string>)
			.ToList();
}
// @lc code=end

