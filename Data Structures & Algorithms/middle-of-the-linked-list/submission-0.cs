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
    public ListNode MiddleNode(ListNode head) {
        var temp = head;

        while (temp != null && temp.next != null){
            temp = temp.next;
            if (temp.next == null)
                return head.next;
            
            temp = temp.next;
            head = head.next;
        }

        return head;
    }
}