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

/*
    建立一个字典，存储的key为相加和为target的值，value是这个数值的下标
    遍历数组，如果当前值不存在当前字典中，计算target-num[i]作为key，下标作为value存入字典。
    如果存在在字典中就直接拿当前的和字典中的下标返回。
*/