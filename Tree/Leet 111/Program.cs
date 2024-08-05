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
    public int MinDepth(TreeNode root) {
        if (root == null)
            return 0;

        Queue<TreeNode> q = new Queue<TreeNode>();

        int dep = 1;

        q.Enqueue(root);

        while (true)
        {
            int count = q.Count;

            for (int i = 0; i < count; i++)
            {
                TreeNode n = q.Dequeue();

                if (n.left == null && n.right == null)
                    return dep;

                if (n.left != null)
                    q.Enqueue(n.left);
                if (n.right != null)
                    q.Enqueue(n.right);
            }

            dep++;
        }

        Console.WriteLine(dep);

        return dep;
    }
}