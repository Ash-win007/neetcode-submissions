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
    public int currentSum = 0;
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null){
            return false;
        }
        
        currentSum += root.val;
        if (HasPathSum(root.left, targetSum)){
            return true;
        }
        if (HasPathSum(root.right, targetSum)){
            return true;
        }

        if (root.left == null && root.right == null && targetSum == currentSum){
            return true;
        }   
        currentSum -= root.val;
        return false;
    }
}