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
        if (list1 == null && list2 == null) {
            return list1;
        }
        if (list2 == null) {
            return list1;
        }
        if (list1 == null) {
            return list2;
        }
        ListNode head;

        if (list1.val <= list2.val) {
            head = list1;
            helper(list1, list1.next, list2);
        }
        else {
            head = list2;
            helper(list2, list1, list2.next);
        }
        return head;
    }

    public void helper(ListNode curEnd, ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null) {
            return;
        }
        if (list1 == null) {
            curEnd.next = list2;
            return;
        }
        if (list2 == null) {
            curEnd.next = list1;
            return;
        }
        if (list1.val <= list2.val) {
            curEnd.next = list1;
            helper(list1, list1.next, list2);
        }
        else {
            curEnd.next = list2;
            helper(list2, list1, list2.next);
        }
    }
}