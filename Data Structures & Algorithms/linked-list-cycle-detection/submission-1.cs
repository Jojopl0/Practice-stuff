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
        //trydouble thing
        ListNode first = head;
        ListNode second = head;
        if (head == null || head.next == null) {
            return false;
        }

        while (first.next != null && second.next != null) {
            first = first.next;
            second = second.next;
            if (second.next != null) {
                second = second.next;
            }
            else {
                break;
            }
            if (first == second) {
                return true;
            }
        }

        return false;
    }
}
