/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        int carry = 0;

        while (l1 != null || l2!= null || carry > 0) {
            int s = carry;

            if (l1 != null) {
                s += l1.val;
                l1 = l1.next;
            }

            if (l2 != null) {
                s += l2.val;
                l2 = l2.next;
            }

            if (s > 9) {
                carry = 1;
                s = s % 10;
            } else {
                carry = 0;
            }

            curr.next = new ListNode(s);
            curr = curr.next;
        }

        return dummy.next;
    }
}
// @lc code=end

/*
    设置carry储存进位
    s为当前位相加
    遍历链表，把进位，当前位的值相加
*/