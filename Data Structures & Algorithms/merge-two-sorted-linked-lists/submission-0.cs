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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head = null, temp;
        temp = head;
        while (list1 != null || list2 != null){
            if (list1 != null && (list2 == null || list1.val <= list2.val)){
                if (temp == null){
                    head = temp = list1;
                }
                else{
                    temp.next = list1;
                    temp = temp.next;
                }
                list1 = list1.next;
            }
            else if (list2 != null) {
                if (temp == null){
                    head = temp = list2;
                }
                else{
                    temp.next = list2;
                    temp = temp.next;
                }
                list2 = list2.next;
            }
        }
        return head;
    }
}