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
public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            bool isValueOver = false;

            List<int> numList = new List<int>();
            List<ListNode> nodeList = new List<ListNode>();

            while (true)
            {
                if (l1 == null)
                    l1 = new ListNode();

                if (l2 == null)
                    l2 = new ListNode();

                int value = l1.val + l2.val;

                if (isValueOver)
                {
                    value++;
                    isValueOver = false;
                }

                if (value >= 10)
                {
                    isValueOver = true;
                    value %= 10;
                }

                numList.Add(value);
                nodeList.Add(new ListNode());

                if (l1.next == null && l2.next == null)
                    break;

                l1 = l1.next;
                l2 = l2.next;
            }

            if (isValueOver)
            {
                numList.Add(1);
                nodeList.Add(new ListNode());
            }


            for (int i = 0; i < nodeList.Count; i++)
            {
                nodeList[i].val = numList[i];

                Console.WriteLine(nodeList[i].val);

                if (i != nodeList.Count - 1)
                    nodeList[i].next = nodeList[i + 1];
            }

            return nodeList[0];
        }

    }