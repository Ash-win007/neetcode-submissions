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
        int size = 0, max = 0, i = 0;
        if (head == null)
            return 0;
        var temp = head;
        while (temp != null){
            size += 1;
            temp = temp.next;
        }

        int[] arr = new int[size/2 + 1];
        temp = head;
        while (temp != null){
            if (i < size/2){
                arr[i] = temp.val;
                
                if (max < arr[i])
                    max = arr[i];
            }
            else{
                arr[size - i - 1] += temp.val;
                
                if (max < arr[size - i - 1])
                    max = arr[size - i - 1];
            }


            temp = temp.next;
            i += 1;
        }

        return max;
    }
}