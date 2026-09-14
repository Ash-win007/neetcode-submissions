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
    private int MinTreeNode(TreeNode root, int val){
        var cur = root;
        while (cur != null && cur.left != null){
            cur = cur.left;
        }
        return cur.val;
    }

    private TreeNode DeleteTreeNode(TreeNode root, int key){
        if (root == null) return null;
        if (root.val < key){
            root.right = DeleteTreeNode(root.right, key);
        }
        else if (root.val > key){
            root.left = DeleteTreeNode(root.left, key);
        }
        else{
            if (root.left is null){
                return root.right;
            }
            else if (root.right is null){
                return root.left;
            }
            var minVal = MinTreeNode(root.right, key);
            root.val = minVal;
            root.right = DeleteTreeNode(root.right, minVal);
        }
        return root;
    }
    public TreeNode DeleteNode(TreeNode root, int key) {
        return DeleteTreeNode(root, key);
    }
}