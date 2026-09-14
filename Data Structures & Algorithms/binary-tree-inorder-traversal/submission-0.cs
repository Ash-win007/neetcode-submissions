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
    private void InOrder(TreeNode root, List<int> list){
        if (root == null){
            return;
        }
        if (root.left != null)
            InOrder(root.left, list);
        if (root.val != null)
            list.Add(root.val);
        if (root.right != null)
            InOrder(root.right, list);
    }

    public List<int> InorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
        InOrder(root, list);    
        return list;
    }
}