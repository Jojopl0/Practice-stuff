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
        if (root == null) {
            return 0;
        }
        if (root.left == null && root.right == null) {
            return 1;
        }
        //if both available, get max
        if (root.left != null && root.right != null) {
            return Math.Max(1 + MaxDepth(root.left), 1 + MaxDepth(root.right));
        }
        //only left path available
        else if (root.left != null) {
            return 1 + MaxDepth(root.left);
        }
        else {
            return 1 + MaxDepth(root.right);
        }
    }
}
