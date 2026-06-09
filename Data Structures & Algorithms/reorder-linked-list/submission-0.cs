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
        seen.RemoveAt(0);
        while (seen.Count > 0) {
            cur.next = seen[seen.Count - 1];
            seen.RemoveAt(seen.Count - 1);
            cur = cur.next;

            if (seen.Count > 0) {
                cur.next = seen[0];
                seen.RemoveAt(0);
                cur = cur.next; 
            }
        }
        cur.next = null;
    }
}
