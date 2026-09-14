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
    private TreeNode InsertRecurse(TreeNode root, int val){
        if (root is null){
            return new TreeNode(val);
        }
        else if (val > root.val){
            root.right = InsertRecurse(root.right, val);
        }
        else if (val < root.val){
            root.left = InsertRecurse(root.left, val);
        }
        return root;
   }

    public TreeNode InsertIntoBST(TreeNode root, int val) {
            return InsertRecurse(root, val);
    }
}