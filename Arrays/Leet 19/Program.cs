
ListNode n5 = new ListNode(5);
ListNode n4 = new ListNode(4,n5);
ListNode n3 = new ListNode(3,n4);
ListNode n2 = new ListNode(2,n3);
ListNode n1 = new ListNode(1,n2);

Solution s = new Solution();
s.RemoveNthFromEnd(n1,2);

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode prevHead = new ListNode(0,head);
        ListNode slow = prevHead;
        ListNode fast = head;

        for (int i = 0; i < n; i++)
            fast = fast.next;

        while (true)
        {
            if(fast == null)
                break;

            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;
        return prevHead.next;

    }
}