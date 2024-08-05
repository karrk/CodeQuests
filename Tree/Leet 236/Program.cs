/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        
        Dictionary<TreeNode,TreeNode> parentDic = new Dictionary<TreeNode, TreeNode>();

        int found = 0;

        stack.Push(root);

        while (stack.Count > 0)
        {
            if(found == 2)
            break;

            TreeNode node = stack.Pop();

            if(node == p || node == q)
                found ++;

            if(node.left != null)
            {   
                parentDic.Add(node.left,node);
                stack.Push(node.left);
            }
                

            if(node.right != null)
            {
                parentDic.Add(node.right,node);
                stack.Push(node.right);
            }
        }

        HashSet<TreeNode> pSet = new HashSet<TreeNode>();

        pSet.Add(p);

        while (true)
        {
            if(!parentDic.ContainsKey(p))
                break;

            TreeNode prev = parentDic[p];
            pSet.Add(prev);
            p = prev;
        }

        while (true)
        {
            if(pSet.Contains(q))
                return q;

            q = parentDic[q];
        }
    }
}