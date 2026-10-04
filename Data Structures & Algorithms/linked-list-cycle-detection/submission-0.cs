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
    public bool HasCycle(ListNode head) {
        if (head == null || head.next == null)
            return false;
        var slow = head;
        while (head != null && head.next != null){
            head = head.next.next;
            slow = slow.next;

            if (head == slow){
                return true;
            }
        }
        return false;
    }
}
