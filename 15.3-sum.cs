/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */
using System.Collections;

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        //We declare the list of lists that will contain our solution
        IList<IList<int>> result = new List<IList<int>>();

        //The edge case
        if (nums.Length <= 2) return result;
        Array.Sort(nums);

        /* Here we declare 3 indexs. This is how it works.
        -4 -2 -3 -1 0 0 0 2 3 10 21
        s  l                     r
        s - start index, l - left index, r - right index */

        int start = 0, left, right;

        /* The target is that the number we are looking for to be composed out of 2
        numbers from our array. For example, if we have the startIndex at -4, we are
        have the startIndex at -4, we are looking for those two numbers in the given
        array which, summed up will be the opposite of -4, which is 4.
        */
        int target;

        /* The start goes from 0 to length02 becuse look here
        -4 -2 -3 -1 0 0 0 2 3 10 21
                            s l  r   */

        while (start < nums.Length-2) {
            target = nums[start] * -1;
            left = start + 1;
            right = nums.Length - 1;

            /* Now, the start index is fixed and we move the left and right indexes 
            to find those two number which summed up will be the oposite of nums[s] */

            while (left < right)
            {
                /* The array is sorted, so if we move to the left the right index, 
                the sum will  decrese */
                if (nums[left] + nums[right] > target) {
                    --right;
                }

                /*Here is the oposite, if the sum of nums[l] and nums[r] is less than
                what we are looking for, then we move the left index, which means that
                the sum will increase due to the sorted array. The left index will jump
                to a bigger value*/
                else if (nums[left] + nums[right] < target) {
                    ++left;
                }
                /* If none of those are true, then it means that nums[l]+nums[r]= our 
                desired value*/
                else {
                    /* Here we create the solution and add it to the list of lists which
                    contains the result.**/
                    List<int> OneSolution = new List<int>() { nums[start], nums[left], nums[right]};
                    result.Add(OneSolution);

                    /*Now, in order to generate different solutions, we have to jump over 
                    repetivie values in the array. */
                    while (left < right && nums[left] == OneSolution[1])
                        ++left;
                    while (left < right && nums[right] == OneSolution[2])
                        --right;
                }
            }
            /*Now we do the same thing to the start index*/
            int currentStartNumber = nums[start];
            while (start < nums.Length - 2 && nums[start]==currentStartNumber)
                ++start;
        }
        return result;
    }
}
// @lc code=end

/*
    排序是一个很好的解决办法，可以去掉重复值，也可以根据数值进行索引查找
*/