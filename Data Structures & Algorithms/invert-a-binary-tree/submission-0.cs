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
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) {
            return root;
        }
        swapChildren(root);
        return root;
    }

    public void swapChildren(TreeNode parent) {
        if (parent.left != null  && parent.right != null ) {
            var temp = parent.left;
            parent.left = parent.right;
            parent.right = temp;
            swapChildren(parent.left);
            swapChildren(parent.right);
        }
        else if (parent.left != null ) {
            parent.right = parent.left;
            parent.left = null;
            swapChildren(parent.right);
        }
        else if (parent.right != null ) {
            parent.left = parent.right;
            parent.right = null;
            swapChildren(parent.left);
        }
        else {
            return;
        }
        
    }
}
