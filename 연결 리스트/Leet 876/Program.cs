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
    public ListNode MiddleNode(ListNode head) {
        ListNode listNode = head;
            int count = 0;

            while (true)
            {
                if (listNode.next == null)
                    break;

                listNode = listNode.next;

                count++;
            }

            int target = count % 2 == 0 ? count / 2 : count / 2 + 1;
            listNode = head;

            for (int i = 0; i < target; i++)
            {
                listNode = listNode.next;
            }

            return listNode;
    }
}