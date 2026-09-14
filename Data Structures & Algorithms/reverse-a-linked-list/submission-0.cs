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
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode next = current.next; // Save the next node
            current.next = previous;      // Reverse the link
            previous = current;           // Move previous forward
            current = next;               // Move current forward
        }

        return previous; // New head of the reversed list                
        }
}
