/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        List<int> subset = new List<int>();
        result.Add(subset);
        Array.Sort(nums);
        // nums.Sort();
        for (int i=0; i<nums.Length; i++) {
            int n = result.Count;
            for (int j=0; j<n; j++) {
                subset = new List<int>(result[j]);
                subset.Add(nums[i]);
                result.Add(new List<int>(subset));
            }
        }
        return result;
    }
}
// @lc code=end

