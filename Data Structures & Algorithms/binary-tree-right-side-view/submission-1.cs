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
    public List<int> RightSideView(TreeNode root) {
        if (root == null){
            return [];
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<int> res = new List<int>();
        
        queue.Enqueue(root);
        while (queue.Count > 0){
            int count = queue.Count;
            for (int i = 0; i < count; i++){
                var node = queue.Dequeue();
                if (i == 0){
                    res.Add(node.val);
                }
                if (node.right != null){
                    queue.Enqueue(node.right);
                }
                if (node.left != null){
                    queue.Enqueue(node.left);
                }
            }
        }
        return res;
    }
}
