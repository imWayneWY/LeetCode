/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++)
        {   
            if (dict.ContainsKey(target - nums[i])) // checks if compliment is in dict
            {
                return new int[] { dict[target - nums[i]], i };
            }
            else if (!dict.ContainsKey(nums[i])) // handles duplicates in array
            {
                dict.Add(nums[i], i);
            }
        }
        
        return null;
    }
}
// @lc code=end

