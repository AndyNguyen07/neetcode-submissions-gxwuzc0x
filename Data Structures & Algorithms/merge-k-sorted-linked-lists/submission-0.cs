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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0 || lists == null) return null;

        var pq = new PriorityQueue<ListNode, int>();

        foreach (var head in lists)
        {
            if (head != null) pq.Enqueue(head,head.val);
        }

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while (pq.Count > 0)
        {
            ListNode node = pq.Dequeue();
            tail.next = node;
            tail = tail.next;

            if (node.next != null)
            {
                pq.Enqueue(node.next, node.next.val);
            }
        }

        return dummy.next;
    }
}
