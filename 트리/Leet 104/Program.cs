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
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;

        Stack<TreeNode> st = new Stack<TreeNode>();
        int max = 0;

        root.val = 1;
        st.Push(root);

        while (true) 
        {
            if (st.Count <= 0)
                break;

            TreeNode node = st.Pop();

            if (node.right != null)
            {
                node.right.val = node.val + 1;
                st.Push(node.right);
            }
                
                
            if (node.left != null)
            {
                node.left.val = node.val + 1;
                st.Push(node.left);
            }

            max = node.val > max ? node.val : max;
                
        }

        return max;
    }
}