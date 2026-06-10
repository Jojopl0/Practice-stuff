# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reorderList(self, head: Optional[ListNode]) -> None:
        front = head;
        mid = head;
        end = head;
        while end.next is not None:
            mid = mid.next
            end = end.next
            if end.next is not None:
                end = end.next
        end = mid.next
        mid.next = None
        end = self.reverse(end)
        cur = head
        front = front.next
        while end:

            cur.next = end
            end = end.next
            cur = cur.next

            cur.next = front
            front = front.next
            cur = cur.next

        if front:
            cur.next = front
            cur = cur.next
            
        if cur:
            cur.next = None
        
        


    def reverse(self, head) -> ListNode:
        prev = None
        cur = head
        while cur:
            nxt = cur.next
            cur.next = prev
            prev = cur
            cur = nxt
        return prev



