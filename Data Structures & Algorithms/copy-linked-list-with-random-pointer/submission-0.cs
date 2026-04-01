/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) return null;

        Node curr = head;

        // Create copy  a - a' - b - b'
        while (curr != null)
        {
            Node copy  = new Node(curr.val);
            copy.next = curr.next;
            curr.next = copy;
            curr = copy.next;
        }

        //Copy random 
        curr = head;
        while (curr != null)
        {
            if (curr.random != null)
            {
                curr.next.random = curr.random.next;
            }
            curr = curr.next.next;
        }

        //Unchain
        curr = head;
        Node newHead = head.next; //head of copy
        Node copyCurr = newHead;

        while(curr != null)
        {
            curr.next = curr.next.next;
            if (copyCurr.next != null)
            {
                copyCurr.next = copyCurr.next.next;
            }
            curr = curr.next;
            copyCurr = copyCurr.next;
        }
        return newHead;
    }
}
