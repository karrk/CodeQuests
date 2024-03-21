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

            HashSet<int> hs = new HashSet<int>();
        bool bFound = false;

    public void FindTarget_rec(TreeNode root, int k)
        {
            if (bFound == true)
                return;

            if (root == null)
                return;

            int pairValue = k - root.val;

            if (hs.Contains(pairValue) == true)
            {
                bFound = true;
            }
            else
            {
                hs.Add(root.val);
            }

            FindTarget_rec(root.left, k);
            FindTarget_rec(root.right, k);


        }
        
    public bool FindTarget(TreeNode root, int k) {
        bFound = false;

            FindTarget_rec(root, k);

            return bFound;
    }
}