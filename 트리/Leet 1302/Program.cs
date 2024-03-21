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
    public int DeepestLeavesSum(TreeNode root) {
        HashSet<TreeNode> nodeHs = new HashSet<TreeNode>();
            HashSet<TreeNode> tempHs;

            nodeHs.Add(root);

            while (true)
            {
                tempHs = new HashSet<TreeNode>();

                foreach (var item in nodeHs)
                {
                    if (item.left != null)
                        tempHs.Add(item.left);

                    if (item.right != null)
                        tempHs.Add(item.right);
                }

                if (tempHs.Count == 0)
                    break;

                nodeHs = tempHs;
            }

            int sum = 0;

            foreach (var item in nodeHs)
            {
                sum += item.val;
            }

            return sum;
    }
}