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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k == 1) return head;
        ListNode dummy = new ListNode(0,head);
        ListNode groupPrev = dummy;
        while (true)
        {
            ListNode kth = GetKth(groupPrev, k);
            if (kth == null) break;
            
            ListNode nextGroup = kth.next;
            
            // Reverse
            ListNode prev = nextGroup;
            ListNode curr = groupPrev.next;

            for (int i = 0; i < k; i++)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            // Connect old k-group to new one
            ListNode tmp = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = tmp;
        }

        return dummy.next;
    }
    private ListNode GetKth(ListNode curr, int k)
    {
        while (curr != null && k > 0)
        {
            curr = curr.next;
            k--;
        }

        return curr;
    }
}
