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
    private int count = 0;
    private int result = -1;

    private void InOrder(TreeNode node, int k){
    if (node == null || result != -1){
        return;
        }

        InOrder(node.left, k);
        count++;
        if (count == k){
            result = node.val;
            return;
        }
        InOrder(node.right, k);

    }

    public int KthSmallest(TreeNode root, int k) {
        InOrder(root, k);
        return result;
    }
}
