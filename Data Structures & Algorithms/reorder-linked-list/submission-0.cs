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
        // Find the mid point
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        // Reverse the latter part 
        ListNode prev = null;
        ListNode curr = slow;
        while (curr != null)
        {
            ListNode nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }
        
        // Merge Two Linked List
        ListNode first = head;
        ListNode second = prev;
        while (second.next != null)
        {
            // Save the next nodes to avoid missing
            ListNode tmp1 = first.next;
            ListNode tmp2 = second.next;
            
            //Merge 
            first.next = second;
            second.next = tmp1;

            first = tmp1;
            second = tmp2;
        }}
}
