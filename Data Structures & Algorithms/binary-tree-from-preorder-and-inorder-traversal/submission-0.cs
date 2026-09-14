public class Solution {
    int preIdx = 0;
    Dictionary<int, int> inorderMap = new Dictionary<int, int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        // Store inorder value → index mappings
        for (int i = 0; i < inorder.Length; i++) {
            inorderMap[inorder[i]] = i;
        }
        return Build(preorder, 0, inorder.Length - 1);
    }

    private TreeNode Build(int[] preorder, int left, int right) {
        if (left > right) return null;
        
        // Get root value from preorder and advance pointer
        int rootVal = preorder[preIdx++];
        TreeNode root = new TreeNode(rootVal);
        
        // Find root position in inorder
        int mid = inorderMap[rootVal];
        
        // Build left and right subtrees
        root.left = Build(preorder, left, mid - 1);
        root.right = Build(preorder, mid + 1, right);
        
        return root;
    }
}