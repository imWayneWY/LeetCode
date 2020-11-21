/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode result = new ListNode();
        ListNode curr = result;

        while (lists != null) {
            var min = int.MaxValue;
            var minList = -1;

            for (int i = 0; i<lists.Length; i++) {
                if (lists[i] != null && lists[i].val < min) {
                    min = lists[i].val;
                    minList = i;
                }
            }

            if (minList  == -1) break;

            lists[minList] = lists[minList].next;
            var node = new ListNode(min);
            curr.next = node;
            curr = node;
        }
        return result.next;
    }
}
// @lc code=end

