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
    public void ReorderList(ListNode head) {
        List<ListNode> seen = new List<ListNode>();

        ListNode cur = head;

        while (cur != null) {
            seen.Add(cur);
            cur = cur.next;
        }


        cur = seen[0];
        ListNode newH = seen[0];
        int len = seen.Count - 1;
        for (int i = 0; i < (seen.Count)/ 2; i++) {
            cur.next = seen[len - i];
            cur = cur.next;

            cur.next = seen[i + 1];
            cur = cur.next;
        }
        cur.next = null;
    }
}
