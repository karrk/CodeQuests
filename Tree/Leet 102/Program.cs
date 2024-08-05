/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> result = new List<IList<int>>();

        if (root == null)
            return result;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        result.Add(new List<int>() { root.val });

        while (true)
        {
            int count = q.Count;

            List<int> temp = new List<int>();

            for (int i = 0; i < count; i++)
            {
                TreeNode n = q.Dequeue();

                if(n.left != null)
                {
                    q.Enqueue(n.left);
                    temp.Add(n.left.val);
                }

                if (n.right != null)
                {
                    q.Enqueue(n.right);
                    temp.Add(n.right.val);
                }
            }

            if (q.Count <= 0)
                break;

            result.Add(temp);
        }

        return result;
    }
}