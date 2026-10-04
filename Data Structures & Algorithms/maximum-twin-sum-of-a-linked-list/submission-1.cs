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
    public int PairSum(ListNode head) {
        // Step 1: find the middle AND reverse the first half in one pass
        ListNode slow = head, fast = head;
        ListNode prev = null;

        while (fast != null && fast.next != null) {
            fast = fast.next.next;
            ListNode tmp = slow.next;
            slow.next = prev;   // reverse as we go
            prev = slow;
            slow = tmp;
        }

        // Now:
        //   prev -> head of reversed first half
        //   slow -> head of second half

        // Step 2: walk both halves together, take twin sums
        int res = 0;
        while (slow != null) {
            res = Math.Max(res, prev.val + slow.val);
            prev = prev.next;
            slow = slow.next;
        }

        return res;
    }
}