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
        if (head == null || head.next == null) {
            return head;
        }
        return helpFunc(null, head);
    }

    private ListNode helpFunc(ListNode prev, ListNode cur) {
        if (cur.next == null) {
            cur.next = prev;
            return cur;
        } 

        ListNode nxt = cur.next;
        cur.next = prev;
        return helpFunc(cur, nxt);



    }
}
