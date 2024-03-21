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
    public ListNode SwapPairs(ListNode head) {
        if(head == null || head.next == null)
            return head;

        ListNode first = head;
        ListNode second = head.next;

        while (true)
        {
            int temp = first.val;
            first.val = second.val;
            second.val = temp;

            if(second.next == null)
                break;
            first = second.next;

            if(first.next == null)
                break;
            second = first.next;
        }

        return head;
    }
}