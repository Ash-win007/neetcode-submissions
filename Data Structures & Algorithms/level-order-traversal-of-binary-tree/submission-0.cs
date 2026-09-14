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
    public List<List<int>> LevelOrder(TreeNode root) {
        if (root == null){
            return [];
        }
        List<List<int>> res = new List<List<int>>();
        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);
        while (nodes.Count > 0){
            List<int> cur = new List<int>();
            var count = nodes.Count;
            for (int i = 0; i < count; i++){
                var node = nodes.Dequeue();
                cur.Add(node.val);
                if (node.left != null){
                    nodes.Enqueue(node.left);
                }
                if (node.right != null){
                    nodes.Enqueue(node.right);
                }
            }
            res.Add(cur);
        }

        return res;
    }
}
